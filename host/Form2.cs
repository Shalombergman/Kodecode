using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host
{
    public partial class Form2 : Form       
    {
        public List<Form2> Forms2;
        public int Position;
        public Form2(List<Form2> forms2,int position, string categoryName)
        {
            InitializeComponent();
            Forms2 = forms2;
            Position = position;
            labCategorey.Text = categoryName;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HostController.selectRows(labCategorey.Text);
        }

        private void labCategorey_Click(object sender, EventArgs e)
        {
           
        }

        private void ButRight_Click(object sender, EventArgs e)
        {
            if (Position < Forms2.Count-1) 
            {
                Forms2[Position].Visible = false;
                Forms2[Position+1].Visible = true;
            }
            else if (Position == Forms2.Count-1) 
            {
                Forms2[Position].Visible = false;
                Forms2[0].Visible = true;
            }
            
        }

        private void ButLeft_Click(object sender, EventArgs e)
        {
            if (Position > 0)
            {
                Forms2[Position].Visible = false;
                Forms2[Position - 1].Visible = true;
            }
            else if (Position == 0)
            {
                Forms2[Position].Visible = false;
                Forms2[Forms2.Count - 1].Visible = true;
            }
        }
    }
}
