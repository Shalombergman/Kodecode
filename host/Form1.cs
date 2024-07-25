using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButOrderPage_Click(object sender, EventArgs e)
        {
            List<Form2>forms = new List<Form2>();
            List<string> categories = HostController.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                forms.Add(new Form2(forms, i, categories[i]));
            }
            forms.First().Show();
        }

        private void listBoxCategorey_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInsertCategorey_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void butInsert_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listCategory();
           
        }
        private void listCategory()
        {
            List<string> categories = HostController.GetCategories();

            foreach (string category in categories)
            {
                listBoxCategorey.Items.Add(category);
            }
            listBoxCategorey.DoubleClick += (Sender, E) =>
            {
                string selectedItem = listBoxCategorey.SelectedItem.ToString();
                if (selectedItem == "") return;
                txtInsertCategorey.Text = selectedItem;
            };

        }
       

        private void txtInsertCategorey_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBoxCategorey.Items.Clear();
            List<string> categories = HostController.searchcategorybyname(txtInsertCategorey.Text);

            foreach (string category in categories)
            {
                listBoxCategorey.Items.Add(category);
            }
            

        }

        public void ButAdd_Click(object sender, EventArgs e)
        {
            HostController.addCategory(txtInsertCategorey.Text);
            List<string> categories = HostController.GetCategories();
            listBoxCategorey.Items.Clear();
            foreach (string category in categories)
            {
                listBoxCategorey.Items.Add(category);
            }
        }

      
    }
    
}
