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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtPepelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButSignIn_Click(object sender, EventArgs e)
        {

        }

        private void ButSignUp_Click(object sender, EventArgs e)
        {
            Coontroller.addStudent(TxtPepelName.Text);
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
