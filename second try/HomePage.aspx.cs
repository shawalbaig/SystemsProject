using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace second_try
{
    public partial class HomePage : System.Web.UI.Page
    {



        private double chicken_breast = 50;
        private double Carrots= 15;
        private double Milk = 10;
        private double OrangeJuice = 22;
        private double Mango_and_orange = 22;
        private double cheese = 50;
        private double potato = 45;
        private double mutton_chops = 75;
        private double Beef_mince = 60;
        private double onions = 40;
        private double Large_eggs = 45;
        private double red_apple = 22;
        private double hotDogs = 55;
        private double Peppers = 12;
        private double Butter = 65;
        private double Mixed_fruit = 22;




        private double Total_Price = 0;
        private double VAT = 0.15;
        private double sub_total = 0;
        private int Quantity = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbcheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Checkout.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Quantity = 0;
            double Chicken_total = 0;
            Quantity = int.Parse(tbchicken.Text);
            if (Quantity <= 0)
            {
                LbCart.Text += "Quantity must be greater than 0:" + Environment.NewLine;
                LbCart.Text += "please clear cart" + Environment.NewLine;



            }
            else
            {

                Chicken_total = chicken_breast * Quantity;

                LbCart.Text += "Chicken Breats 1kg X " + Quantity + " " + "R " + Chicken_total.ToString() + Environment.NewLine;

                sub_total += Chicken_total;

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Quantity = 0;
            double Carrot_total = 0;
            Quantity = int.Parse(tbcarrots.Text);
            if (Quantity <= 0)
            {
                LbCart.Text += "Quantity must be greater than 0:" + Environment.NewLine;
                LbCart.Text += "please clear cart" + Environment.NewLine;



            }
            else
            {

                Carrot_total = Carrots * Quantity;

                LbCart.Text += "Carrots 1kg X " + Quantity + " " + "R " + Carrot_total.ToString() + Environment.NewLine;

                sub_total += Carrot_total;

            }

        }
    }
}