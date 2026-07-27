using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" ||
               TextBox3.Text == "" || RadioButtonList1.SelectedIndex == -1)
            {
                Label2.Text = "Please fill all the fields";
                return;
            }

            String name = TextBox1.Text;
            String enroll = TextBox2.Text;
            String email = TextBox3.Text;
            String gender = RadioButtonList1.SelectedItem.Text;
            String course = DropDownList1.SelectedItem.Text;
            String hobby = DropDownList2.SelectedItem.Text;

            Label2.Text = "<br/>" +" Name: " + name + "<br/>" + "Enrollment No: " + enroll + "<br/>" + "Email: " + email + "<br/>" + "Gender: " + gender + "<br/>" + "Course: " + course + "<br/>" + "Hobby: " + hobby;


        }
    }
}