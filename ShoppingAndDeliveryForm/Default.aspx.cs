using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingAndDeliveryForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
            {
                Label5.Text = "Please select a Product from ListBox";
                return;
            }
            if (TextBox1.Text == "")
            {
                Label5.Text = "Please enter the Quantity";
                return;

            }
            if (DropDownList1.SelectedItem == null)
            {
                Label5.Text = "Please select a Payment Method from DropDownList";
                return;
            }
            if (RadioButtonList1.SelectedItem == null)
            {
                Label5.Text = "Please select a Delivery Option from RadioButtonList";
                return;
            }

            string products = "";
            if (ListBox1.SelectedIndex != -1)
            {
                foreach (ListItem item in ListBox1.Items)
                {
                    if (item.Selected)
                    {
                        products += item.Value + "  ";
                    }
                }
            }

            Label5.Text = "You have selected the following products: " + products + "<br/>" +
                "Quantity: " + TextBox1.Text + "<br/>" +
                "Payment Method: " + DropDownList1.SelectedItem.Text + "<br/>" +
                "Delivery Option: " + RadioButtonList1.SelectedItem.Text;

        }
    }
}