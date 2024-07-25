using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guests_and_hosts
{
    public partial class Form2ChoiceCategorey : Form
    {

        public List<Form2ChoiceCategorey> Forms2;
        public int Position;
        public string name;
        public Form2ChoiceCategorey(List<Form2ChoiceCategorey> forms2, int position, string categoryName, string name)
        {
            InitializeComponent();
            Forms2 = forms2;
            Position = position;
            lablCategorey.Text = categoryName;
            this.name = name;

        }

        private void lablCategorey_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2ChoiceCategorey_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GuestContrroller.selectRowsDidNotChoose(lablCategorey.Text);
            dataGridView2.DataSource = GuestContrroller.selectRowsDidChoose(lablCategorey.Text);
        }

        private void ButRight_Click(object sender, EventArgs e)
        {
            if (Position < Forms2.Count - 1)
            {
                Forms2[Position].Visible = false;
                Forms2[Position + 1].Visible = true;
            }
            else if (Position == Forms2.Count - 1)
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

        private void TxtCoiceFood_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
