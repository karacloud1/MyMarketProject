using Business.Concrete;
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
using System.Windows.Forms;

namespace MyMarketProject
{
    public partial class Form_login : Form
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public static List<Product> products;
        public static DataTable productTable;

        public Form_login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            panel_register.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_register.Visible = false;
        }

        private void button_regClear_Click(object sender, EventArgs e)
        {
            textBox_regId.Clear();
            textBox_regPw.Clear();
            textBox_regAdress.Clear();
            textBox_regTel.Clear();
            textBox_regMail.Clear();
            textBox_regName.Clear();
            textBox_regSurname.Clear();

        }


        private void button_login_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Form3.user = userManager.GetByNameAndPw(textBox_id.Text, textBox_password.Text).Data; 
            if (Form3.user != null)
            {
                GetProduct(Form_CustomerMain.first);
                Form_CustomerMain.first = true;
                if (Form3.user.UserTypeID == 2)
                {
                    this.Hide();
                    Form_CustomerMain form_CustomerMain = new Form_CustomerMain();
                    form_CustomerMain.ShowDialog();
                    
                }
                else
                {
                    this.Hide();
                    Form_WorkerMain form_WorkerMain = new Form_WorkerMain();
                    form_WorkerMain.ShowDialog();
                    
                }

            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre yanlis!");
            }
        }


        private void GetProduct(Boolean b)
        {
            if (!b)
            {
                products = productManager.GetAll().Data;
                productTable = new DataTable();
                productTable.Columns.Add("ÜrünResmi", typeof(Image));
                productTable.Columns.Add("ÜrünId", typeof(int));
                productTable.Columns.Add("ÜrünAdı", typeof(string));
                productTable.Columns.Add("ÜrünFiyatı", typeof(int));
                productTable.Columns.Add("StokAdeti", typeof(int));
                productTable.Columns.Add("KategoriId", typeof(int));
                productTable.Columns.Add("ÜrünResimYolu", typeof(string));


                products.RemoveAt(0);
                foreach (var item in products)
                {
                    productTable.Rows.Add(GetProductImage(item.ProductPhotoPath), item.ProductId, item.ProductName, 
                        item.ProductPrice, item.ProductAmount, item.CategoryId, item.ProductPhotoPath);
                }
            }


        }
        public Image GetProductImage(string productPhotoPath)
        {

            var request = WebRequest.Create(productPhotoPath);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Image image = Bitmap.FromStream(stream);
                return image;
            }
        }
        private void button_regComplete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserTypeID = 2;
            user.Name = textBox_regName.Text;
            user.Surname = textBox_regSurname.Text;
            user.UserName = textBox_regId.Text;
            user.UserPassword = textBox_regPw.Text;
            user.UserTelephone = textBox_regTel.Text;
            user.UserMail = textBox_regMail.Text;
            user.UserAddress = textBox_regAdress.Text;
            UserManager userManager = new UserManager(new EfUserDal());
            MessageBox.Show(userManager.Add(user).Message);
        }

        private void textBox_regTel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_regTel.Text, "[^0-9]"))
            {
                MessageBox.Show("Lüten sadece sayi girin.");
                textBox_regTel.Text = textBox_regTel.Text.Remove(textBox_regTel.Text.Length - 1);
            }
        }
    }
}
