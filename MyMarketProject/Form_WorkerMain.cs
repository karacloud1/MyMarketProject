using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMarketProject
{
    public partial class Form_WorkerMain : Form
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());       
        ProductManager productManager = new ProductManager(new EfProductDal());
        PictureBox pictureBox = new PictureBox();

        public Form_WorkerMain()
        {
            InitializeComponent();
            pictureBox.Visible = false;
            pictureBox.Height = pictureBox.Width;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form_WorkerMain_Load(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                comboBox_category.Items.Add(item.CategoryName);
            }
            dataGridView_wProducts.DataSource = Form_login.productTable;
            dataGridView_wProducts.Columns["ÜrünResmi"].Width = 180;
            dataGridView_wProducts.Columns["ÜrünAdı"].Width = 400;
            dataGridView_wProducts.Columns["ÜrünFiyatı"].Width = 100;
            dataGridView_wProducts.Columns["StokAdeti"].Width = 75;
            dataGridView_wProducts.Columns["ÜrünId"].Width = 75;
            dataGridView_wProducts.Columns["KategoriId"].Width = 100;

            dataGridView_wOrders.DataSource = orderManager.GetAll().Data;


        }

        private void dataGridView_wProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_pId.Text = dataGridView_wProducts.CurrentRow.Cells[1].Value.ToString();
            textBox_pName.Text = dataGridView_wProducts.CurrentRow.Cells[2].Value.ToString();
            textBox_pPrice.Text = dataGridView_wProducts.CurrentRow.Cells[3].Value.ToString();
            textBox_pAmount.Text = dataGridView_wProducts.CurrentRow.Cells[4].Value.ToString();
            comboBox_category.SelectedIndex = Convert.ToInt32(dataGridView_wProducts.CurrentRow.Cells[5].Value);
            textBox_pPhoto.Text = dataGridView_wProducts.CurrentRow.Cells[6].Value.ToString();
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_pId.Clear();
            textBox_pName.Clear();
            textBox_pPrice.Clear();
            textBox_pAmount.Clear();
            textBox_pPhoto.Clear();
            comboBox_category.SelectedIndex = 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.ProductName = textBox_pName.Text;
            product.ProductPhotoPath = textBox_pPhoto.Text;
            product.ProductPrice = Convert.ToInt32(textBox_pPrice.Text);
            product.ProductAmount = Convert.ToInt32(textBox_pAmount.Text);
            product.CategoryId = Convert.ToInt32(comboBox_category.SelectedIndex);


            var control = Form_login.products.FirstOrDefault(p=> p.ProductName == product.ProductName || p.ProductPhotoPath == product.ProductPhotoPath);
            if (control != null)
            {
                MessageBox.Show("Bu ürün zaten veri tabanında bulunuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = productManager.Add(product);
                int lastProductId = productManager.GetById(Form_login.products.LastOrDefault().ProductId + 1).Data.ProductId;
                MessageBox.Show(result.Message);
                if (result.Success)
                {
                    pictureBox.Load(product.ProductPhotoPath);
                    Form_login.productTable.Rows.Add(
                        pictureBox.Image,
                        lastProductId,
                        product.ProductName,
                        product.ProductPrice,
                        product.ProductAmount,
                        product.CategoryId,
                        product.ProductPhotoPath
                        );
                    product.ProductId = lastProductId;
                    Form_login.products.Add(product);
                }
                dataGridView_wProducts.DataSource = Form_login.productTable;
            }
            
            

        }

        private void button_update_Click(object sender, EventArgs e)
        {

            Product product = new Product();
            product = new Product();
            product.ProductId = Convert.ToInt32(textBox_pId.Text);
            product.ProductName = textBox_pName.Text;
            product.ProductPhotoPath = textBox_pPhoto.Text;
            product.ProductPrice = Convert.ToInt32(textBox_pPrice.Text);
            product.ProductAmount = Convert.ToInt32(textBox_pAmount.Text);
            product.CategoryId = Convert.ToInt32(comboBox_category.SelectedIndex);
            var result = productManager.Update(product);
            MessageBox.Show(result.Message);
            if (result.Success)
            {
                pictureBox.Load(product.ProductPhotoPath);
                DataRow dr = Form_login.productTable.Select("ÜrünId=" + product.ProductId.ToString()).FirstOrDefault();
                if (dr != null)
                {
                    dr["ÜrünResmi"] = pictureBox.Image;
                    dr["ÜrünAdı"] = product.ProductName;
                    dr["ÜrünFiyatı"] = product.ProductPrice;
                    dr["StokAdeti"] = product.ProductAmount;
                    dr["KategoriId"] = product.CategoryId;
                    dr["ÜrünResimYolu"] = product.ProductPhotoPath;
                }
                dataGridView_wProducts.DataSource = Form_login.productTable;
                var obj = Form_login.products.FirstOrDefault(x => x.ProductId == product.ProductId);
                if (obj != null)
                {
                    obj.CategoryId = product.CategoryId;
                    obj.ProductAmount = product.ProductAmount;
                    obj.ProductPrice = product.ProductPrice;
                    obj.ProductPhotoPath = product.ProductPhotoPath;
                    obj.ProductName = product.ProductName;
                }
            }



        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ürün silenecek emin misiniz?", "Ürün hakkında", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(textBox_pId.Text);
                var result = productManager.Delete(product);
                MessageBox.Show(result.Message);
                if (result.Success)
                {
                    Form_login.products.RemoveAll(p => p.ProductId == product.ProductId);
                    DataRow dr = Form_login.productTable.Select("ÜrünId=" + product.ProductId.ToString()).FirstOrDefault();
                    if (dr != null)
                    {
                        dr.Delete();
                    }
                    dataGridView_wProducts.DataSource = Form_login.productTable;
                }
            }

            
        }

        private void textbox_pSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = Form_login.productTable.DefaultView;
            dv.RowFilter = "ÜrünAdı LIKE'%" + textbox_pSearch.Text + "%'";
            dataGridView_wProducts.DataSource = dv;
        }

        private void textBox_pPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_pPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Lüten sadece sayi girin.");
                textBox_pPrice.Clear();
            }
        }

        private void textBox_pAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_pAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Lüten sadece sayi girin.");
                textBox_pAmount.Clear();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ana menüye dönülüyor emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form_login form_Login = new Form_login();
                form_Login.ShowDialog();
            }
        }
    }
}
