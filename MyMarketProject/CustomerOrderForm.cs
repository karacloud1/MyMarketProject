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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMarketProject
{
    public partial class CustomerOrderForm : Form
    {

        public static List<int> order = new List<int>();

        public CustomerOrderForm()
        {
            InitializeComponent();

        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ÜrünId", typeof(int));
            table.Columns.Add("ÜrünAdı", typeof(string));
            table.Columns.Add("ÜrünFiyatı", typeof(int));
            table.Columns.Add("StokAdeti", typeof(int));

            foreach (var item in Form_login.products.FindAll(p => order.Contains(p.ProductId)))
            {
                table.Rows.Add(item.ProductId, item.ProductName, item.ProductPrice, item.ProductAmount);
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns["ÜrünId"].Visible = false;
            dataGridView1.Columns["ÜrünAdı"].Width = 500;
            CalculateTotal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.Clear();
            MessageBox.Show(order.Count().ToString());
            Form_CustomerMain.adet = 0;
            dataGridView1.Columns.Clear();
            textBox_oName.Clear();
            textBox_oPrice.Clear();
            CalculateTotal();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox_oName.Text = dataGridView1.CurrentRow.Cells["ÜrünAdı"].Value.ToString();
            textBox_oPrice.Text = dataGridView1.CurrentRow.Cells["ÜrünFiyatı"].Value.ToString();
        }
        private void CalculateTotal()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["ÜrünFiyatı"].Value);

            }

            textBox_oTotal.Text = sum.ToString();
        }

        private void button_pDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            try
            {
                order.Remove(Convert.ToInt32(dataGridView1.Rows[0].Cells["ÜrünId"].Value));
                if (dataGridView1.CurrentCell !=null )
                {
                    rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    Form_CustomerMain.adet--;
                }
                
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
            CalculateTotal();

        }

        private void button_oOkay_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(dataGridView1.Rows[0].Cells["StokAdeti"].Value) <=0)
            {
                MessageBox.Show(Messages.InvalidProductAmount);
            }
            else
            {
                Form_CustomerMain form_CustomerMain = new Form_CustomerMain();
                ProductManager productManager = new ProductManager(new EfProductDal());
                OrderManager orderManager = new OrderManager(new EfOrderDal());
                Product product;
                Order orders;
                foreach (var item in Form_login.products.FindAll(p => order.Contains(p.ProductId)))
                {
                    orders = new Order();
                    orders.OrderDate = DateTime.Now;
                    orders.ProductId = item.ProductId;
                    orders.UserId = Form3.user.UserID;
                    orderManager.Add(orders);
                    product = new Product();
                    product.ProductId = item.ProductId;
                    product.ProductName = item.ProductName.ToString();
                    product.CategoryId = item.CategoryId;
                    product.ProductAmount = item.ProductAmount -1;
                    product.ProductPhotoPath = item.ProductPhotoPath.ToString();
                    product.ProductPrice = item.ProductPrice;
                    productManager.Update(product);
                    item.ProductAmount--;
                    form_CustomerMain.UpdateTable(item.ProductId,item.ProductAmount);
                }
                MessageBox.Show(Messages.CustomerPurchaseSuccessful);

            }

        }
    }
}
