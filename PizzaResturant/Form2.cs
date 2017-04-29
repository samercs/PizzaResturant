using System;
using System.Windows.Forms;
using PizzaResturant.Model;

namespace PizzaResturant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Size pizzaSize = (Size)Enum.Parse(typeof(Size), comboBox1.Text);
            var pizza = new Pizza(pizzaSize)
            {
                ExtraCheese = checkBox1.Checked,
                Size = comboBox1.Text,
                Thickness = comboBox2.Text,
                Topping1 = textBox1.Text,
                Topping2 = textBox2.Text,
                Topping3 = textBox3.Text
            };

            Size beverageSize = (Size)Enum.Parse(typeof(Size), comboBox3.Text);
            var beverage = new Beverage(beverageSize)
            {
                Type = comboBox4.Text,
                Diet = checkBox2.Checked,
                Cold = checkBox3.Checked
            };

            Size dessertSize = (Size)Enum.Parse(typeof(Size), comboBox5.Text);
            var dessert = new Dessert(dessertSize)
            {
                Type = comboBox6.Text
            };

            Program.FormData.Order.Pizza = pizza;
            Program.FormData.Order.Dessert = dessert;
            Program.FormData.Order.Beverage = beverage;

            var payment = new Form3();
            payment.Show();
            this.Hide();


        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
