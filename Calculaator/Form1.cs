using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculaator
{
    public partial class Form1 : Form
    {

        private TextBox selectedTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void butOne_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 1;
        }

        private void butTow_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 2;
        }

        private void butThree_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 3;
        }
        private void butFor_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 4;
        }

        private void butFive_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 5;
        }

        private void butSix_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 6;
        }

        private void butSeven_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 7;
        }

        private void butEight_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 8;
        }

        private void butNine_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 9;
        }

        private void butZero_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += 0;
        }*/
        private void butPlus_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "+";
            selectedTextBox = txtNumber2;
        }
        private void butMinus_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "-";
            selectedTextBox = txtNumber2;
        }
        private void butMultiplication_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "x";
            selectedTextBox = txtNumber2;
        }

        private void butDivision_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "/";
            selectedTextBox = txtNumber2;
        }

        private void txtNumber1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void txtNumber2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void butDot_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += ".";
        }

        

        private void butEquals_Click_1(object sender, EventArgs e)
        {
            // 1. convert 'string' to int
            float num1 = float.Parse(txtNumber1.Text);
            float num2 = float.Parse(txtNumber2.Text);

            // 2. validate input
            //if (num1 !=|| num2 )

            if (cmbOperator.Text == "+")
            {
                lblResult.Text = (num1 + num2).ToString();
            }
            else if (cmbOperator.Text == "-")
            {
                lblResult.Text = (num1 - num2).ToString();
            }
            else if (cmbOperator.Text == "x")
            {
                lblResult.Text = (num1 * num2).ToString();
            }
            else if (cmbOperator.Text == "/")
            {

                // - check that txtNumber2 is not o
                if (num2 == 0)
                {
                    lblResult.Text = "Cannot divide by 0";
                    return;
                }

                lblResult.Text = (num1 / num2).ToString();
            }
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text = null;
        }
        private void butOne_Click_Global(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
        }
    }
}
