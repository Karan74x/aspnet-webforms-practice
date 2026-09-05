using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the page is opening for the first time
            if (!IsPostBack)
            {
                // Check whether a Username cookie already exists
                if (Request.Cookies["Username"] != null)
                {
                    TextBox1.Text = Request.Cookies["Username"].Value;
                    CheckBox1.Checked = true;
                    Label3.Text = "Username retrived";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Get the username entered in TextBox1
           string username = TextBox1.Text;

            // Check whether Username OR Password is empty
            if (TextBox1.Text.Trim()=="" || TextBox2.Text.Trim()=="")
          {
              Label3.Text = "Please fill in all fields"; 
          }
          else
          {
                //Check Remember me
                if (CheckBox1.Checked)
                {
                    // Store the username inside a cookie
                    Response.Cookies["Username"].Value = username;

                    //Cookies expires after 30 days
                    Response.Cookies["Username"].Expires = DateTime.Now.AddDays(30);


                    // Show success message
                    Label3.Text = "Login Successful . username saved in cookies";
                }
                else
                {
                    // User did NOT select Remember Me.
                    // Delete the existing Username cookie
                    Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);

                    Label3.Text = "Login Successfull";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            CheckBox1.Checked = false;
            Label3.Text = "Successfully Logout";
        }
    }
}