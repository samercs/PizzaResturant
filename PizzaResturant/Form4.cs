using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaResturant
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var order = Program.FormData.Order;
            lblTitle.Text = order.Person.Title;
            lblFName.Text = order.Person.FName;
            lblLName.Text = order.Person.LName;
            lblPhoneNumber.Text = order.Person.PhoneNumber;
            lblPName.Text = order.Person.PaymentInfo.Name;
            lblPCCN.Text = order.Person.PaymentInfo.CreditCardNo;
            lblPCCT.Text = order.Person.PaymentInfo.CreditCardType;
            lblPED.Text = order.Person.PaymentInfo.ExpireDate.ToString("MM yyyy");
            lblPSC.Text = order.Person.PaymentInfo.SecurityCode;
            lblACountry.Text = order.Address.Country;
            lblAArea.Text = order.Address.Area;
            lblABlock.Text = order.Address.Block;
            lblABuilddingNumber.Text = order.Address.BuildingNumber;
            lblAFlatNo.Text = order.Address.FlatNo;
            lblAStreet.Text = order.Address.Street;
            lblAZipCode.Text = order.Address.ZipCode;
            lblPiSize.Text = order.Pizza.Size;
            lblPiThickness.Text = order.Pizza.Thickness;
            lblPiExtaCheese.Text = order.Pizza.ExtraCheese ? "Yes" : "No";
            lblPiTopping.Text = order.Pizza.Topping1 + ", " + order.Pizza.Topping2 + ", " + order.Pizza.Topping3;
            lblDSize.Text = order.Dessert.Size;
            lblDType.Text = order.Dessert.Type;
            lblBType.Text = order.Beverage.Type;
            lblBSize.Text = order.Beverage.Size;
            lblBCold.Text = order.Beverage.Cold ? "Yes" : "No";
            lblBDiet.Text = order.Beverage.Diet ? "Yes" : "No";
            lblTotal.Text = order.GetTotal().ToString("00.00 K.D");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You order has been submit successfully. Thank you");
            var main = new Form1();
            main.Show();
            this.Hide();
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
