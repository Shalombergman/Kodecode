namespace guests_and_hosts
{
    partial class Form2ChoiceCategorey
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
            this.TxtCoiceFood = new System.Windows.Forms.TextBox();
            this.ButChoiceOk = new System.Windows.Forms.Button();
            this.ButAddChoice = new System.Windows.Forms.Button();
            this.LblMyChoice = new System.Windows.Forms.Label();
            this.LalChoiceAllGuests = new System.Windows.Forms.Label();
            this.lablCategorey = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButLeft = new System.Windows.Forms.Button();
            this.ButRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCoiceFood
            // 
            this.TxtCoiceFood.Location = new System.Drawing.Point(277, 226);
            this.TxtCoiceFood.Name = "TxtCoiceFood";
            this.TxtCoiceFood.Size = new System.Drawing.Size(100, 20);
            this.TxtCoiceFood.TabIndex = 15;
            this.TxtCoiceFood.TextChanged += new System.EventHandler(this.TxtCoiceFood_TextChanged);
            // 
            // ButChoiceOk
            // 
            this.ButChoiceOk.Location = new System.Drawing.Point(127, 226);
            this.ButChoiceOk.Name = "ButChoiceOk";
            this.ButChoiceOk.Size = new System.Drawing.Size(75, 23);
            this.ButChoiceOk.TabIndex = 14;
            this.ButChoiceOk.Text = "אישור";
            this.ButChoiceOk.UseVisualStyleBackColor = true;
            // 
            // ButAddChoice
            // 
            this.ButAddChoice.Location = new System.Drawing.Point(438, 226);
            this.ButAddChoice.Name = "ButAddChoice";
            this.ButAddChoice.Size = new System.Drawing.Size(102, 23);
            this.ButAddChoice.TabIndex = 13;
            this.ButAddChoice.Text = "הוסף בחירה";
            this.ButAddChoice.UseVisualStyleBackColor = true;
            // 
            // LblMyChoice
            // 
            this.LblMyChoice.AutoSize = true;
            this.LblMyChoice.Location = new System.Drawing.Point(603, 267);
            this.LblMyChoice.Name = "LblMyChoice";
            this.LblMyChoice.Size = new System.Drawing.Size(70, 13);
            this.LblMyChoice.TabIndex = 12;
            this.LblMyChoice.Text = "הבחירה שלי";
            // 
            // LalChoiceAllGuests
            // 
            this.LalChoiceAllGuests.AutoSize = true;
            this.LalChoiceAllGuests.Location = new System.Drawing.Point(541, 27);
            this.LalChoiceAllGuests.Name = "LalChoiceAllGuests";
            this.LalChoiceAllGuests.Size = new System.Drawing.Size(130, 13);
            this.LalChoiceAllGuests.TabIndex = 11;
            this.LalChoiceAllGuests.Text = "הבחירה של כל האורחים";
            // 
            // lablCategorey
            // 
            this.lablCategorey.AutoSize = true;
            this.lablCategorey.Location = new System.Drawing.Point(386, 27);
            this.lablCategorey.Name = "lablCategorey";
            this.lablCategorey.Size = new System.Drawing.Size(35, 13);
            this.lablCategorey.TabIndex = 10;
            this.lablCategorey.Text = "label1";
            this.lablCategorey.Click += new System.EventHandler(this.lablCategorey_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(127, 267);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(413, 141);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 155);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ButLeft
            // 
            this.ButLeft.Location = new System.Drawing.Point(127, 415);
            this.ButLeft.Name = "ButLeft";
            this.ButLeft.Size = new System.Drawing.Size(75, 23);
            this.ButLeft.TabIndex = 16;
            this.ButLeft.Text = "<<<";
            this.ButLeft.UseVisualStyleBackColor = true;
            this.ButLeft.Click += new System.EventHandler(this.ButLeft_Click);
            // 
            // ButRight
            // 
            this.ButRight.Location = new System.Drawing.Point(465, 415);
            this.ButRight.Name = "ButRight";
            this.ButRight.Size = new System.Drawing.Size(75, 23);
            this.ButRight.TabIndex = 18;
            this.ButRight.Text = ">>>";
            this.ButRight.UseVisualStyleBackColor = true;
            this.ButRight.Click += new System.EventHandler(this.ButRight_Click);
            // 
            // Form2ChoiceCategorey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButRight);
            this.Controls.Add(this.ButLeft);
            this.Controls.Add(this.TxtCoiceFood);
            this.Controls.Add(this.ButChoiceOk);
            this.Controls.Add(this.ButAddChoice);
            this.Controls.Add(this.LblMyChoice);
            this.Controls.Add(this.LalChoiceAllGuests);
            this.Controls.Add(this.lablCategorey);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2ChoiceCategorey";
            this.Text = "Form2ChoiceCategorey";
            this.Load += new System.EventHandler(this.Form2ChoiceCategorey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCoiceFood;
        private System.Windows.Forms.Button ButChoiceOk;
        private System.Windows.Forms.Button ButAddChoice;
        private System.Windows.Forms.Label LblMyChoice;
        private System.Windows.Forms.Label LalChoiceAllGuests;
        private System.Windows.Forms.Label lablCategorey;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButLeft;
        private System.Windows.Forms.Button ButRight;
    }
}