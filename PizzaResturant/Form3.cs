using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaResturant.Model;

namespace PizzaResturant
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblOrderTotal.Text = Program.FormData.Order.GetTotal().ToString("00.00 K.D");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var payment = new PaymentInfo
            {
                Name = textBox1.Text,
                CreditCardNo = textBox2.Text,
                CreditCardType = comboBox1.Text,
                ExpireDate = new DateTime(int.Parse(comboBox3.Text), int.Parse(comboBox2.Text), 1),
                SecurityCode = textBox3.Text
            };
            Program.FormData.Order.Person.PaymentInfo = payment;
            var summary = new Form4();
            summary.Show();
            this.Hide();
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
