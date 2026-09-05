using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView_with_DataTable_Example
{
    public partial class _Default : Page
    {
        //Runs when the page is loaded
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the page is loaded for the first time
            if (!IsPostBack)
            {
                //show student data
                DisplayStudents();
            }
        }

        //Method creates and shows the students
        public void DisplayStudents()
        {
            //Create a Table to stort student data
            DataTable dt = new DataTable();

            //Add columns to table
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Student Name");
            dt.Columns.Add("Course");
            dt.Columns.Add("Marks");

            //Add rows to table
            dt.Rows.Add("1", "Karan", "C#", "99");
            dt.Rows.Add("2", "Anas", "Python", "85");
            dt.Rows.Add("3", "Aman", "Java", "95");
            dt.Rows.Add("4", "Arnold", "Flutter", "45");
            dt.Rows.Add("5", "Saad", "Ai/ML", "55");

            //Connect the table with Gridview
            GridView1.DataSource = dt;

            //Show the data in gridView
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}