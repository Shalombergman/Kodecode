namespace DrinksVendingMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LablnamefDrink = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSugar = new System.Windows.Forms.ComboBox();
            this.ComboBoxCoffee = new System.Windows.Forms.ComboBox();
            this.ComboBoxMilk = new System.Windows.Forms.ComboBox();
            this.ComboBoxCocoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonUpdating = new System.Windows.Forms.Button();
            this.ButtonAddition = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMilk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCoffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameDrink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LablnamefDrink
            // 
            this.LablnamefDrink.AutoSize = true;
            this.LablnamefDrink.Location = new System.Drawing.Point(1036, 63);
            this.LablnamefDrink.Name = "LablnamefDrink";
            this.LablnamefDrink.Size = new System.Drawing.Size(80, 13);
            this.LablnamefDrink.TabIndex = 0;
            this.LablnamefDrink.Text = " name the drink";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(1036, 148);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(35, 13);
            this.lblSugar.TabIndex = 1;
            this.lblSugar.Text = "Sugar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(921, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "coffee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "milk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "cocoa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(924, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxSugar
            // 
            this.comboBoxSugar.FormattingEnabled = true;
            this.comboBoxSugar.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.comboBoxSugar.Location = new System.Drawing.Point(1029, 197);
            this.comboBoxSugar.Name = "comboBoxSugar";
            this.comboBoxSugar.Size = new System.Drawing.Size(47, 21);
            this.comboBoxSugar.TabIndex = 7;
            this.comboBoxSugar.SelectedIndexChanged += new System.EventHandler(this.comboBoxSugar_SelectedIndexChanged);
            // 
            // ComboBoxCoffee
            // 
            this.ComboBoxCoffee.FormattingEnabled = true;
            this.ComboBoxCoffee.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.ComboBoxCoffee.Location = new System.Drawing.Point(924, 197);
            this.ComboBoxCoffee.Name = "ComboBoxCoffee";
            this.ComboBoxCoffee.Size = new System.Drawing.Size(47, 21);
            this.ComboBoxCoffee.TabIndex = 8;
            this.ComboBoxCoffee.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCoffee_SelectedIndexChanged);
            // 
            // ComboBoxMilk
            // 
            this.ComboBoxMilk.FormattingEnabled = true;
            this.ComboBoxMilk.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.ComboBoxMilk.Location = new System.Drawing.Point(782, 197);
            this.ComboBoxMilk.Name = "ComboBoxMilk";
            this.ComboBoxMilk.Size = new System.Drawing.Size(47, 21);
            this.ComboBoxMilk.TabIndex = 9;
            this.ComboBoxMilk.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMilk_SelectedIndexChanged);
            // 
            // ComboBoxCocoa
            // 
            this.ComboBoxCocoa.FormattingEnabled = true;
            this.ComboBoxCocoa.Items.AddRange(new object[] {
            "0.0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.ComboBoxCocoa.Location = new System.Drawing.Point(647, 197);
            this.ComboBoxCocoa.Name = "ComboBoxCocoa";
            this.ComboBoxCocoa.Size = new System.Drawing.Size(47, 21);
            this.ComboBoxCocoa.TabIndex = 10;
            this.ComboBoxCocoa.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCocoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(512, 197);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(49, 20);
            this.textBoxPrice.TabIndex = 12;
            this.textBoxPrice.Text = "4";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // buttonUpdating
            // 
            this.buttonUpdating.Location = new System.Drawing.Point(272, 285);
            this.buttonUpdating.Name = "buttonUpdating";
            this.buttonUpdating.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdating.TabIndex = 13;
            this.buttonUpdating.Text = "updating";
            this.buttonUpdating.UseVisualStyleBackColor = true;
            this.buttonUpdating.Visible = false;
            this.buttonUpdating.Click += new System.EventHandler(this.buttonUpdating_Click);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.Location = new System.Drawing.Point(126, 285);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddition.TabIndex = 15;
            this.ButtonAddition.Text = "addition";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.Click += new System.EventHandler(this.ButtonAddition_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 285);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(126, 372);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(75, 23);
            this.ButSave.TabIndex = 19;
            this.ButSave.Text = "Save";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(462, 177);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(22, 21);
            this.buttonPlus.TabIndex = 21;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinase
            // 
            this.buttonMinase.Location = new System.Drawing.Point(462, 215);
            this.buttonMinase.Name = "buttonMinase";
            this.buttonMinase.Size = new System.Drawing.Size(22, 20);
            this.buttonMinase.TabIndex = 23;
            this.buttonMinase.Text = "-";
            this.buttonMinase.UseVisualStyleBackColor = true;
            this.buttonMinase.Click += new System.EventHandler(this.buttonMinase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPrice,
            this.ColumnCocoa,
            this.ColumnMilk,
            this.ColumnCoffee,
            this.ColumnSugar,
            this.ColumnNameDrink});
            this.dataGridView1.Location = new System.Drawing.Point(454, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 220);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnCocoa
            // 
            this.ColumnCocoa.HeaderText = "Cocoa";
            this.ColumnCocoa.Name = "ColumnCocoa";
            // 
            // ColumnMilk
            // 
            this.ColumnMilk.HeaderText = "Milk";
            this.ColumnMilk.Name = "ColumnMilk";
            // 
            // ColumnCoffee
            // 
            this.ColumnCoffee.HeaderText = "Coffee";
            this.ColumnCoffee.Name = "ColumnCoffee";
            // 
            // ColumnSugar
            // 
            this.ColumnSugar.HeaderText = "Sugar";
            this.ColumnSugar.Name = "ColumnSugar";
            // 
            // ColumnNameDrink
            // 
            this.ColumnNameDrink.HeaderText = "Name Drink";
            this.ColumnNameDrink.Name = "ColumnNameDrink";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMinase);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.ButtonAddition);
            this.Controls.Add(this.buttonUpdating);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBoxCocoa);
            this.Controls.Add(this.ComboBoxMilk);
            this.Controls.Add(this.ComboBoxCoffee);
            this.Controls.Add(this.comboBoxSugar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.LablnamefDrink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LablnamefDrink;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxSugar;
        private System.Windows.Forms.ComboBox ComboBoxCoffee;
        private System.Windows.Forms.ComboBox ComboBoxMilk;
        private System.Windows.Forms.ComboBox ComboBoxCocoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonUpdating;
        private System.Windows.Forms.Button ButtonAddition;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMilk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCoffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameDrink;
    }
}

