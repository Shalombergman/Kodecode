namespace host
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
            this.lalinsertCategor = new System.Windows.Forms.Label();
            this.txtInsertCategorey = new System.Windows.Forms.TextBox();
            this.butInsert = new System.Windows.Forms.Button();
            this.listBoxCategorey = new System.Windows.Forms.ListBox();
            this.ButOrderPage = new System.Windows.Forms.Button();
            this.ButAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalinsertCategor
            // 
            this.lalinsertCategor.AutoSize = true;
            this.lalinsertCategor.Location = new System.Drawing.Point(402, 67);
            this.lalinsertCategor.Name = "lalinsertCategor";
            this.lalinsertCategor.Size = new System.Drawing.Size(91, 13);
            this.lalinsertCategor.TabIndex = 0;
            this.lalinsertCategor.Text = "הכנסת קטגוריות";
            // 
            // txtInsertCategorey
            // 
            this.txtInsertCategorey.Location = new System.Drawing.Point(405, 112);
            this.txtInsertCategorey.Name = "txtInsertCategorey";
            this.txtInsertCategorey.Size = new System.Drawing.Size(100, 20);
            this.txtInsertCategorey.TabIndex = 1;
            this.txtInsertCategorey.TextChanged += new System.EventHandler(this.txtInsertCategorey_TextChanged);
            this.txtInsertCategorey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInsertCategorey_KeyPress);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(418, 180);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(75, 23);
            this.butInsert.TabIndex = 2;
            this.butInsert.Text = "הכנס";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // listBoxCategorey
            // 
            this.listBoxCategorey.FormattingEnabled = true;
            this.listBoxCategorey.Location = new System.Drawing.Point(397, 244);
            this.listBoxCategorey.Name = "listBoxCategorey";
            this.listBoxCategorey.Size = new System.Drawing.Size(108, 134);
            this.listBoxCategorey.TabIndex = 3;
            this.listBoxCategorey.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorey_SelectedIndexChanged);
            // 
            // ButOrderPage
            // 
            this.ButOrderPage.Location = new System.Drawing.Point(120, 263);
            this.ButOrderPage.Name = "ButOrderPage";
            this.ButOrderPage.Size = new System.Drawing.Size(142, 45);
            this.ButOrderPage.TabIndex = 4;
            this.ButOrderPage.Text = "הסתכל בהזמנה";
            this.ButOrderPage.UseVisualStyleBackColor = true;
            this.ButOrderPage.Click += new System.EventHandler(this.ButOrderPage_Click);
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(367, 152);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 23);
            this.ButAdd.TabIndex = 5;
            this.ButAdd.Text = "הוסף";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.ButOrderPage);
            this.Controls.Add(this.listBoxCategorey);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.txtInsertCategorey);
            this.Controls.Add(this.lalinsertCategor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalinsertCategor;
        private System.Windows.Forms.TextBox txtInsertCategorey;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.ListBox listBoxCategorey;
        private System.Windows.Forms.Button ButOrderPage;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button button2;
    }
}

