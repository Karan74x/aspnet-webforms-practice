using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentRegisterationPanel
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim() == "")
            {
                Label4.Text = "Please Enter Student Name";
            }

            //check if course is Selected
            else if(DropDownList1.SelectedIndex == -1)
            {
                Label4.Text = "Please Select Course";
            }
            else
            {
                Label4.Text = "Student Name: "+TextBox1.Text + "<br/> Course: " + DropDownList1.SelectedItem.Text;
            }
        }
    }
}