using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DrinksVendingMachine
{
    public partial class Form1 : Form
    {
        private DrinksController  drinksController;
        public Form1()
        {
            InitializeComponent();
            XmlDocument drinksDocument = MainProject.Main();
            drinksController = new DrinksController(drinksDocument);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<string>>drinksList = drinksController.GetDrinksData();
            foreach (List<string> drink in drinksList)
            {
                dataGridView1.Rows.Add(drink.ToArray());
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = (float.Parse(textBoxPrice.Text) + 0.5).ToString();
        }

        private void buttonMinase_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = (float.Parse(textBoxPrice.Text) - 0.5).ToString();
        }
        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                 textBoxPrice.Text,
                 comboBoxSugar.Text,
                 ComboBoxCoffee.Text,
                 ComboBoxCocoa.Text,
                 ComboBoxMilk.Text,
                 textBox1.Text
            };
            drinksController.AddDrinks(drinks);

            dataGridView1.Rows.Add(drinks.ToArray());
        }
        private void ButSave_Click(object sender, EventArgs e)
        {
            drinksController.Save();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<string> drinks = drinksController.GetDrinksByName(textBox1.Text);
            if (drinks == null) return;
            DialogResult result = MessageBox.Show("האם ברצונך לעדכן ?","עדכן משקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            textBoxPrice.Text = drinks[1];
            comboBoxSugar.Text = drinks[2];
            ComboBoxCoffee.Text = drinks[3];
            ComboBoxCocoa.Text = drinks[4];
            ComboBoxMilk.Text = drinks[5];
            buttonUpdating.Visible = true;
            ButtonAddition.Visible = false;

        }

        private void comboBoxSugar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxMilk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCocoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void buttonUpdating_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                 textBoxPrice.Text,
                 comboBoxSugar.Text,
                 ComboBoxCoffee.Text,
                 ComboBoxCocoa.Text,
                 ComboBoxMilk.Text,
                 textBox1.Text
            };
            drinksController.UpdateDrink(drinks);
            ButtonAddition.Visible = true;
            buttonUpdating.Visible = false;
            dataGridView1.Rows.Clear();
            List<List<string>> drinklist = drinksController.GetDrinksData();
            foreach(List<string> drink in drinklist)
            {
                dataGridView1.Rows.Add(drink.ToArray());
            }
           
        }

        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                 textBoxPrice.Text,
                 comboBoxSugar.Text,
                 ComboBoxCoffee.Text,
                 ComboBoxCocoa.Text,
                 ComboBoxMilk.Text,
                 textBox1.Text
            };
            drinksController.DeleteDrink(drinks);
            dataGridView1.Rows.Clear();
            List<List<string>> drinklist = drinksController.GetDrinksData();
            foreach (List<string> drink in drinklist)
            {
                dataGridView1.Rows.Add(drink.ToArray());
            }
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }     
    }
}
