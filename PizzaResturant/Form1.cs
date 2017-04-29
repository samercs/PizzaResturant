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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FormData = new FormData();
            Program.FormData.Order = new Order();
            Program.FormData.Order.Person = new Person()
            {
                FName = textBox1.Text,
                Title = comboBox1.Text,
                LName = textBox2.Text,
                PhoneNumber = textBox3.Text
            };
            Program.FormData.Order.Address = new Address
            {
                Country = textBox4.Text,
                Area = textBox5.Text,
                Block = textBox6.Text,
                BuildingNumber = textBox7.Text,
                FlatNo = textBox8.Text,
                Street = textBox9.Text,
                ZipCode = textBox10.Text
            };
            var foodSelection = new Form2();
            foodSelection.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
