using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String hobbies = "";

            foreach(ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    hobbies += " " + item.Text;
                }
            }
            Label2.Text = "Selected Hobbies "+hobbies;
        }
    }
}