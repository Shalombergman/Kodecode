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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButAddName_Click(object sender, EventArgs e)
        {
            GuestContrroller.addGuestName(TxtInsertName.Text);
            List<string> guestName = GuestContrroller.GetGuestName();
            listBoxName.Items.Clear();
            foreach (string guests in guestName)
            {
                listBoxName.Items.Add(guests);
            }
        }
        private void TxtInsertName_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBoxName.Items.Clear();
            List<string> guestName = GuestContrroller.searcheGuestsName(TxtInsertName.Text);

            foreach (string guests in guestName)
            {
                listBoxName.Items.Add(guests);
            }
        }

        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> guestName = GuestContrroller.GetGuestName();

            foreach (string guests in guestName)
            {
                listBoxName.Items.Add(guests);
            }

            listBoxName.DoubleClick += (Sender, E) =>
            {
                
                string selectedItem = listBoxName.SelectedItem.ToString();
                if (selectedItem == "") return;
                TxtInsertName.Text = selectedItem;

            };
        }

        private void ButOk_Click(object sender, EventArgs e)
        {
            string name = TxtInsertName.Text;
            List<Form2ChoiceCategorey> forms = new List<Form2ChoiceCategorey>();
            List<string> guestName = GuestContrroller.GetGuestName();
            for (int i = 0; i < guestName.Count; i++)
            {
                forms.Add(new Form2ChoiceCategorey(forms, i, guestName[i],name));
            }
            forms.First().Show();
        }

        private void ButDeleteName_Click(object sender, EventArgs e)
        {

        }

        

        private void labInsertName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
