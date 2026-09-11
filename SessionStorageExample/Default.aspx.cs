using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStorageExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string product = DropDownList1.SelectedItem.Text;
            string quantity = TextBox1.Text;
            Session["Product"] = product;
            Session["Quantity"] = quantity;
            Label4.Text = "Product added to cart";

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx");
        }
    }
}