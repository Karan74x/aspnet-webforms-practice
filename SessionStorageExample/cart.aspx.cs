using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStorageExample
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Product"] != null && Session["Quantity"] != null)
            {
                string product = Session["Product"].ToString();
                string quantity = Session["Quantity"].ToString();
                Label1.Text = "Cart " +
                    "<br>" + "Product: " + product +
                    "<br>" + "Quantity: " + quantity;
            }else
            {
                Label1.Text = "Your Cart is Empty";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}