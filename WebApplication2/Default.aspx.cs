using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = "/images/BOND&BOOK.jpeg";
            Image1.Width = 300;
            Image1.Height = 200;
            Image1.AlternateText = "BOND";

            HyperLink1.Text = "James Bond Official Website";
            HyperLink1.NavigateUrl = "https://www.jamesbond.com";
            HyperLink1.Target = "_blank";
        }
    }
}