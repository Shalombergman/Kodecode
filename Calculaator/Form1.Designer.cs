namespace Calculaator
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butTow = new System.Windows.Forms.Button();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butOne = new System.Windows.Forms.Button();
            this.butFor = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.butSix = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.butFive = new System.Windows.Forms.Button();
            this.butMultiplication = new System.Windows.Forms.Button();
            this.butNine = new System.Windows.Forms.Button();
            this.butEight = new System.Windows.Forms.Button();
            this.butSeven = new System.Windows.Forms.Button();
            this.butZero = new System.Windows.Forms.Button();
            this.butDivision = new System.Windows.Forms.Button();
            this.butThree = new System.Windows.Forms.Button();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.butDot = new System.Windows.Forms.Button();
            this.butEquals = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNumber1.Location = new System.Drawing.Point(3, 3);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(114, 20);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNumber1.Enter += new System.EventHandler(this.txtNumber1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.butTow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNumber2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.butOne, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.butFor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.butPlus, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.butSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.butMinus, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.butFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.butMultiplication, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.butNine, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.butEight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.butSeven, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNumber1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.butDivision, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.butThree, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbOperator, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butDot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.butEquals, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.butReset, 4, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // butTow
            // 
            this.butTow.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butTow.Location = new System.Drawing.Point(123, 38);
            this.butTow.Name = "butTow";
            this.butTow.Size = new System.Drawing.Size(114, 42);
            this.butTow.TabIndex = 10;
            this.butTow.Text = "2";
            this.butTow.UseVisualStyleBackColor = false;
            //this.butTow.Click += new System.EventHandler(this.butTow_Click);
            // 
            // txtNumber2
            // 
            this.txtNumber2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNumber2.Location = new System.Drawing.Point(243, 3);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(114, 20);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.Enter += new System.EventHandler(this.txtNumber2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // butOne
            // 
            this.butOne.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butOne.Location = new System.Drawing.Point(3, 38);
            this.butOne.Name = "butOne";
            this.butOne.Size = new System.Drawing.Size(114, 42);
            this.butOne.TabIndex = 9;
            this.butOne.Text = "1";
            this.butOne.UseVisualStyleBackColor = false;
            //this.butOne.Click += new System.EventHandler(this.butOne_Click);
            // 
            // butFor
            // 
            this.butFor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butFor.Location = new System.Drawing.Point(3, 87);
            this.butFor.Name = "butFor";
            this.butFor.Size = new System.Drawing.Size(114, 49);
            this.butFor.TabIndex = 12;
            this.butFor.Text = "4";
            this.butFor.UseVisualStyleBackColor = false;
            //this.butFor.Click += new System.EventHandler(this.butFor_Click);
            // 
            // butPlus
            // 
            this.butPlus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butPlus.Location = new System.Drawing.Point(373, 38);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(75, 42);
            this.butPlus.TabIndex = 13;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = false;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // butSix
            // 
            this.butSix.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSix.Location = new System.Drawing.Point(243, 87);
            this.butSix.Name = "butSix";
            this.butSix.Size = new System.Drawing.Size(114, 49);
            this.butSix.TabIndex = 14;
            this.butSix.Text = "6";
            this.butSix.UseVisualStyleBackColor = false;
            //this.butSix.Click += new System.EventHandler(this.butSix_Click);
            // 
            // butMinus
            // 
            this.butMinus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butMinus.Location = new System.Drawing.Point(373, 87);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(75, 49);
            this.butMinus.TabIndex = 15;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = false;
            this.butMinus.Click += new System.EventHandler(this.butMinus_Click);
            // 
            // butFive
            // 
            this.butFive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butFive.Location = new System.Drawing.Point(123, 87);
            this.butFive.Name = "butFive";
            this.butFive.Size = new System.Drawing.Size(114, 49);
            this.butFive.TabIndex = 16;
            this.butFive.Text = "5";
            this.butFive.UseVisualStyleBackColor = false;
            //this.butFive.Click += new System.EventHandler(this.butFive_Click);
            // 
            // butMultiplication
            // 
            this.butMultiplication.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butMultiplication.Location = new System.Drawing.Point(373, 144);
            this.butMultiplication.Name = "butMultiplication";
            this.butMultiplication.Size = new System.Drawing.Size(75, 44);
            this.butMultiplication.TabIndex = 17;
            this.butMultiplication.Text = "x";
            this.butMultiplication.UseVisualStyleBackColor = false;
            this.butMultiplication.Click += new System.EventHandler(this.butMultiplication_Click);
            // 
            // butNine
            // 
            this.butNine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butNine.Location = new System.Drawing.Point(243, 144);
            this.butNine.Name = "butNine";
            this.butNine.Size = new System.Drawing.Size(114, 44);
            this.butNine.TabIndex = 18;
            this.butNine.Text = "9";
            this.butNine.UseVisualStyleBackColor = false;
            //this.butNine.Click += new System.EventHandler(this.butNine_Click);
            // 
            // butEight
            // 
            this.butEight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butEight.Location = new System.Drawing.Point(123, 144);
            this.butEight.Name = "butEight";
            this.butEight.Size = new System.Drawing.Size(114, 44);
            this.butEight.TabIndex = 19;
            this.butEight.Text = "8";
            this.butEight.UseVisualStyleBackColor = false;
            //this.butEight.Click += new System.EventHandler(this.butEight_Click);
            // 
            // butSeven
            // 
            this.butSeven.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butSeven.Location = new System.Drawing.Point(3, 144);
            this.butSeven.Name = "butSeven";
            this.butSeven.Size = new System.Drawing.Size(114, 44);
            this.butSeven.TabIndex = 20;
            this.butSeven.Text = "7";
            this.butSeven.UseVisualStyleBackColor = false;
            //this.butSeven.Click += new System.EventHandler(this.butSeven_Click);
            // 
            // butZero
            // 
            this.butZero.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butZero.Location = new System.Drawing.Point(123, 203);
            this.butZero.Name = "butZero";
            this.butZero.Size = new System.Drawing.Size(114, 43);
            this.butZero.TabIndex = 23;
            this.butZero.Text = "0";
            this.butZero.UseVisualStyleBackColor = false;
            //this.butZero.Click += new System.EventHandler(this.butZero_Click);
            // 
            // butDivision
            // 
            this.butDivision.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butDivision.Location = new System.Drawing.Point(373, 203);
            this.butDivision.Name = "butDivision";
            this.butDivision.Size = new System.Drawing.Size(75, 43);
            this.butDivision.TabIndex = 22;
            this.butDivision.Text = "/";
            this.butDivision.UseVisualStyleBackColor = false;
            this.butDivision.Click += new System.EventHandler(this.butDivision_Click);
            // 
            // butThree
            // 
            this.butThree.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butThree.Location = new System.Drawing.Point(243, 38);
            this.butThree.Name = "butThree";
            this.butThree.Size = new System.Drawing.Size(114, 42);
            this.butThree.TabIndex = 24;
            this.butThree.Text = "3";
            this.butThree.UseVisualStyleBackColor = false;
            //this.butThree.Click += new System.EventHandler(this.butThree_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(123, 3);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(114, 21);
            this.cmbOperator.TabIndex = 25;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(373, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "result";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // butDot
            // 
            this.butDot.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butDot.Location = new System.Drawing.Point(243, 203);
            this.butDot.Name = "butDot";
            this.butDot.Size = new System.Drawing.Size(114, 43);
            this.butDot.TabIndex = 26;
            this.butDot.Text = ".";
            this.butDot.UseVisualStyleBackColor = false;
            this.butDot.Click += new System.EventHandler(this.butDot_Click);
            // 
            // butEquals
            // 
            this.butEquals.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.butEquals.Location = new System.Drawing.Point(3, 203);
            this.butEquals.Name = "butEquals";
            this.butEquals.Size = new System.Drawing.Size(114, 43);
            this.butEquals.TabIndex = 27;
            this.butEquals.Text = "=";
            this.butEquals.UseVisualStyleBackColor = false;
            this.butEquals.Click += new System.EventHandler(this.butEquals_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(373, 256);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(75, 23);
            this.butReset.TabIndex = 28;
            this.butReset.Text = "reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button butTow;
        private System.Windows.Forms.Button butOne;
        private System.Windows.Forms.Button butFor;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button butSix;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button butFive;
        private System.Windows.Forms.Button butMultiplication;
        private System.Windows.Forms.Button butNine;
        private System.Windows.Forms.Button butEight;
        private System.Windows.Forms.Button butSeven;
        private System.Windows.Forms.Button butDivision;
        private System.Windows.Forms.Button butZero;
        private System.Windows.Forms.Button butThree;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button butDot;
        private System.Windows.Forms.Button butEquals;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.Button button2;
    }
}

