namespace TimeClockWithSql
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
            this.lblId = new System.Windows.Forms.Label();
            this.LblInsertPassword = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtInsertPassword = new System.Windows.Forms.TextBox();
            this.ButChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(388, 93);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(90, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "הכנס מספר זהות";
            // 
            // LblInsertPassword
            // 
            this.LblInsertPassword.AutoSize = true;
            this.LblInsertPassword.Location = new System.Drawing.Point(398, 250);
            this.LblInsertPassword.Name = "LblInsertPassword";
            this.LblInsertPassword.Size = new System.Drawing.Size(70, 13);
            this.LblInsertPassword.TabIndex = 1;
            this.LblInsertPassword.Text = "הכנס סיסמא";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(378, 123);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 2;
            this.TxtId.Text = "23";
            // 
            // TxtInsertPassword
            // 
            this.TxtInsertPassword.Location = new System.Drawing.Point(378, 290);
            this.TxtInsertPassword.Name = "TxtInsertPassword";
            this.TxtInsertPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtInsertPassword.TabIndex = 3;
            //this.TxtInsertPassword.TextChanged += new System.EventHandler(this.TxtInsertPassword_TextChanged);
            this.TxtInsertPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInsertPassword_KeyPress);
            // 
            // ButChangePassword
            // 
            this.ButChangePassword.Location = new System.Drawing.Point(606, 370);
            this.ButChangePassword.Name = "ButChangePassword";
            this.ButChangePassword.Size = new System.Drawing.Size(106, 23);
            this.ButChangePassword.TabIndex = 4;
            this.ButChangePassword.Text = "החלף סיסמא";
            this.ButChangePassword.UseVisualStyleBackColor = true;
            this.ButChangePassword.Click += new System.EventHandler(this.ButChangePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButChangePassword);
            this.Controls.Add(this.TxtInsertPassword);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblInsertPassword);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label LblInsertPassword;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtInsertPassword;
        private System.Windows.Forms.Button ButChangePassword;
    }
}

