namespace guests_and_hosts
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
            this.labInsertName = new System.Windows.Forms.Label();
            this.TxtInsertName = new System.Windows.Forms.TextBox();
            this.ButDeleteName = new System.Windows.Forms.Button();
            this.ButAddName = new System.Windows.Forms.Button();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.ButOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labInsertName
            // 
            this.labInsertName.AutoSize = true;
            this.labInsertName.Location = new System.Drawing.Point(418, 44);
            this.labInsertName.Name = "labInsertName";
            this.labInsertName.Size = new System.Drawing.Size(142, 13);
            this.labInsertName.TabIndex = 0;
            this.labInsertName.Text = "הכנס או בחר שם מהרשימה";
            this.labInsertName.Click += new System.EventHandler(this.labInsertName_Click);
            // 
            // TxtInsertName
            // 
            this.TxtInsertName.Location = new System.Drawing.Point(442, 81);
            this.TxtInsertName.Name = "TxtInsertName";
            this.TxtInsertName.Size = new System.Drawing.Size(100, 20);
            this.TxtInsertName.TabIndex = 1;
            this.TxtInsertName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInsertName_KeyPress);
            // 
            // ButDeleteName
            // 
            this.ButDeleteName.Location = new System.Drawing.Point(556, 165);
            this.ButDeleteName.Name = "ButDeleteName";
            this.ButDeleteName.Size = new System.Drawing.Size(75, 23);
            this.ButDeleteName.TabIndex = 2;
            this.ButDeleteName.Text = "מחיקה";
            this.ButDeleteName.UseVisualStyleBackColor = true;
            this.ButDeleteName.Click += new System.EventHandler(this.ButDeleteName_Click);
            // 
            // ButAddName
            // 
            this.ButAddName.Location = new System.Drawing.Point(366, 165);
            this.ButAddName.Name = "ButAddName";
            this.ButAddName.Size = new System.Drawing.Size(75, 23);
            this.ButAddName.TabIndex = 3;
            this.ButAddName.Text = "הוסף";
            this.ButAddName.UseVisualStyleBackColor = true;
            this.ButAddName.Click += new System.EventHandler(this.ButAddName_Click);
            // 
            // listBoxName
            // 
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.Location = new System.Drawing.Point(421, 238);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(144, 95);
            this.listBoxName.TabIndex = 4;
            this.listBoxName.SelectedIndexChanged += new System.EventHandler(this.listBoxName_SelectedIndexChanged);
            // 
            // ButOk
            // 
            this.ButOk.Location = new System.Drawing.Point(453, 373);
            this.ButOk.Name = "ButOk";
            this.ButOk.Size = new System.Drawing.Size(75, 23);
            this.ButOk.TabIndex = 5;
            this.ButOk.Text = "אישור";
            this.ButOk.UseVisualStyleBackColor = true;
            this.ButOk.Click += new System.EventHandler(this.ButOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButOk);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.ButAddName);
            this.Controls.Add(this.ButDeleteName);
            this.Controls.Add(this.TxtInsertName);
            this.Controls.Add(this.labInsertName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInsertName;
        private System.Windows.Forms.TextBox TxtInsertName;
        private System.Windows.Forms.Button ButDeleteName;
        private System.Windows.Forms.Button ButAddName;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.Button ButOk;
    }
}

