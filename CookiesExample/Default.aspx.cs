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
            if(!IsPostBack)
            {
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
            string username = TextBox1.Text;
          if (TextBox1.Text.Trim()=="" || TextBox2.Text.Trim()=="")
          {
              Label3.Text = "Please fill in all fields"; 
          }
          else
          {
                //Check Remember me
                if (CheckBox1.Checked)
                {
                    Response.Cookies["Username"].Value = username;

                    //Cookies expires after 30 days
                    Response.Cookies["Username"].Expires = DateTime.Now.AddDays(30);

                    Label3.Text = "Login Successful . username saved in cookies";
                }
                else
                {
                    //Delete the cookie
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