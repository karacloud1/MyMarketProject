using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class Form3 : Form
    {
        public static User user;
        OrderManager orderManager = new OrderManager(new EfOrderDal());
        List<OrderDetailDto> orders = new List<OrderDetailDto>();
        DataTable table = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            orders.Clear();
            table.Rows.Clear();
            textBox_cuName.Text = user.Name;
            textBox_cuSurname.Text = user.Surname;
            textBox_cuId.Text = user.UserName;
            textBox_cuPw.Text = user.UserPassword;
            textBox_cuAddress.Text = user.UserAddress;
            textBox_cuTel.Text = user.UserTelephone;
            textBox_cuEmail.Text = user.UserMail;
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            orders = orderManager.GetOrderDetails(user.UserID).Data;
            table.Columns.Add("ÜrünAdı", typeof(string));
            table.Columns.Add("SiparişTarihi", typeof(DateTime));

            foreach (var item in orders)
            {
                table.Rows.Add(item.ProductName, item.OrderDate);
            }

            dataGridView_cuOrder.DataSource = table;


        }

        private void button_cuUpdate_Click(object sender, EventArgs e)
        {

            user.UserTypeID = 2;
            user.Name = textBox_cuName.Text;
            user.Surname = textBox_cuSurname.Text;
            user.UserName = textBox_cuId.Text;
            user.UserPassword = textBox_cuPw.Text;
            user.UserTelephone = textBox_cuTel.Text;
            user.UserMail = textBox_cuEmail.Text;
            user.UserAddress = textBox_cuAddress.Text;
            UserManager userManager = new UserManager(new EfUserDal());
            MessageBox.Show(userManager.Update(user).Message);
        }

        private void textBox_cuTel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_cuTel.Text, "[^0-9]"))
            {
                MessageBox.Show("Lüten sadece sayi girin.");
                textBox_cuTel.Text = textBox_cuTel.Text.Remove(textBox_cuTel.Text.Length - 1);
            }
        }
    }
}
