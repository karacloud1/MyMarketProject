using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMarketProject
{
    public partial class Form_CustomerMain : Form
    {
        public static int adet = 0;
        public static Boolean first = false;
        public Form_CustomerMain()
        {
            InitializeComponent();    

        }

        public void UpdateTable(int id,int productAmount)
        {
            DataRow dr = Form_login.productTable.Select("ÜrünId="+id.ToString()).FirstOrDefault(); 
            if (dr != null)
            {
                dr["StokAdeti"] = productAmount;
            }
            dataGridView_cu.DataSource = Form_login.productTable;
            dataGridView_cu.Refresh();

        }

        private void Form_CustomerMain_Load(object sender, EventArgs e)
        {
            dataGridView_cu.DataSource = Form_login.productTable;
            dataGridView_cu.Columns.Add(new DataGridViewImageColumn()
            {
                Image = Image.FromFile(@"E:\visual studio repos\MyMarketProject\MyMarketProject\Resources\add-to-cart.png"),
                Name = "SepeteEkle",
                HeaderText = "",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                

            }); ;
            dataGridView_cu.Columns["ÜrünId"].Visible = false;
            dataGridView_cu.Columns["KategoriId"].Visible = false;
            dataGridView_cu.Columns["ÜrünResimYolu"].Visible = false;
            dataGridView_cu.Columns["ÜrünResmi"].Width = 180;
            dataGridView_cu.Columns["ÜrünAdı"].Width = 725;
            dataGridView_cu.Columns["ÜrünFiyatı"].Width = 100;
            dataGridView_cu.Columns["StokAdeti"].Width = 75;
            dataGridView_cu.Columns["SepeteEkle"].Width = 64;
            


        }



        private void button_cuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ana menüye dönülüyor emin misiniz?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                CustomerOrderForm.order.Clear();
                adet = 0;
                this.Hide();
                Form_login form_Login = new Form_login();
                form_Login.ShowDialog();
            }
        }

        private void button_cuOkay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(textBox_cuLow.Text) > Convert.ToInt16(textBox_cuMax.Text))
                {
                    MessageBox.Show(Messages.InvalidProductMaxAndMin);
                }
                DataView dv = Form_login.productTable.DefaultView;
                dv.RowFilter = String.Format("ÜrünFiyatı >= {0} AND ÜrünFiyatı <= {1} AND ÜrünAdı LIKE '%{2}%'", textBox_cuLow.Text, textBox_cuMax.Text, textBox_cuSearch.Text);
                dataGridView_cu.DataSource = dv;
                
            }
            catch (Exception exception)
            {
                textBox_cuLow.Clear();
                textBox_cuMax.Clear();
                MessageBox.Show(Messages.InvalidProductMaxAndMin);
            }


        }

        private void textBox_cuSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = Form_login.productTable.DefaultView;
            dv.RowFilter = "ÜrünAdı LIKE'%" + textBox_cuSearch.Text + "%'";
            dataGridView_cu.DataSource = dv;
        }

        private void dataGridView_cu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_cu.Columns["SepeteEkle"].Index)
            {
                int selectedrowindex = dataGridView_cu.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_cu.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["ÜrünId"].Value);
                if (CustomerOrderForm.order.Contains(Convert.ToInt16(selectedRow.Cells["ÜrünId"].Value)))
                {
                    MessageBox.Show("Ürün zaten sepette var.");
                }
                else
                {
                    CustomerOrderForm.order.Add(Convert.ToInt16(selectedRow.Cells["ÜrünId"].Value));
                    MessageBox.Show(Messages.ProductBuy);
                    adet++;
                    label_cuOrderCount.Text = (adet).ToString();
                }

            }
        }

        private void button_cuSettings_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerOrderForm customerOrderForm = new CustomerOrderForm();
            customerOrderForm.ShowDialog();
        }

        private void dataGridView_cu_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            label_cuOrderCount.Text = adet.ToString();
            label_cuOrderCount.Refresh();
        }
    }
}
