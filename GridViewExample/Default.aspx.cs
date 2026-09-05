using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GridViewExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Karan", Department = "MCA", Marks = 80 },
                new Student { Name = "Anas", Department = "BCA", Marks = 70 },
                new Student { Name = "Aman", Department = "MCA", Marks = 75 },
                new Student { Name = "Arnold", Department = "BCA", Marks = 95 }
            };

            //LINQ[Language Integrated Query] : Find MCA students
            var result = students.Where(s => s.Department == "MCA").ToList();

            // Find BCA students
            var res1 = students.Where(s => s.Department == "BCA").ToList();

            //Print all students
            var res2 = students.ToList();

            
            // Find Name starts with K
            var res3 = students.Where(s => s.Name.StartsWith("K")).ToList();

            //Name contains something
            var res4 = students.Where(s => s.Name.Contains("an")).ToList();

            //Name ends with something
            var res5 = students.Where(s => s.Name.EndsWith("d")).ToList();


            //Greater than / less than
            var output = students.Where(s => s.Marks > 70).ToList();

            var output2 = students.Where(s => s.Marks < 80).ToList();


            //Multiple conditions AND → && , OR → ||

            // 1. Find MCA students whose Marks are greater than 80:
            var final = students.Where(s => s.Department == "MCA" && s.Marks > 79).ToList();

            // 2. Find MCA or BCA students:
            var final2 = students.Where(s => s.Department == "MCA" || s.Department == "BCA").ToList();

            // Select only student names
            var select1 = students.Select(s => s.Name).ToList();

            //Select student names and departments
            var select2 = students.Select(s => new { s.Name, s.Department }).ToList();


            //Sort students by Name
            var order1 = students.OrderBy(s => s.Name).ToList();

            // Sort students by Marks
            var order2 = students.OrderBy(s => s.Marks).ToList();

            GridView1.DataSource = res3;
            GridView1.DataBind();
            
        }
        public class Student
        {
            public string Name { get; set; }
            public string Department { get; set; }

            public int Marks { get; set; }

        }
    }
}