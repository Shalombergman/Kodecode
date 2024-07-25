using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TxtChoiceCourse_TextChanged(object sender, EventArgs e)
        {
            Coontroller.SearchceCoursesName(TxtChoiceCourse.Text);
        }

        private void ListBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<string> courses = Coontroller.GetCourses();

            foreach (string course in courses)
            {
                ListBoxCourses.Items.Add(course);
            }
            ListBoxCourses.DoubleClick += (Sender, E) =>
            {
                string selectedItem = ListBoxCourses.SelectedItem.ToString();
                if (selectedItem == "") return;
                TxtChoiceCourse.Text = selectedItem;
            };
            Coontroller.GetCourses();
        }

        private void ButAddCourse_Click(object sender, EventArgs e)
        {

            Coontroller.addStudentCourse(TxtChoiceCourse.Text);
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void ButSignUpCourse_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> courses = Coontroller.GetCourses();

            foreach (string course in courses)
            {
                ListBoxCourses.Items.Add(course);
            }

            ListBoxCourses.DoubleClick += (Sender, E) =>
            {
                string selectedItem = ListBoxCourses.SelectedItem.ToString();
               
                if (selectedItem == "") return;
                TxtChoiceCourse.Text = selectedItem;
            };
            
        }
    }
}
