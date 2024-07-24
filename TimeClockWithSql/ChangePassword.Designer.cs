namespace TimeClockWithSql
{
    partial class ChangePassword
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
            this.LblOldpassword = new System.Windows.Forms.Label();
            this.TxtOldPassword = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.LblconfirmPassword = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.ButConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOldpassword
            // 
            this.LblOldpassword.AutoSize = true;
            this.LblOldpassword.Location = new System.Drawing.Point(599, 147);
            this.LblOldpassword.Name = "LblOldpassword";
            this.LblOldpassword.Size = new System.Drawing.Size(70, 13);
            this.LblOldpassword.TabIndex = 0;
            this.LblOldpassword.Text = "סיסמא ישנה";
            // 
            // TxtOldPassword
            // 
            this.TxtOldPassword.Location = new System.Drawing.Point(461, 140);
            this.TxtOldPassword.Name = "TxtOldPassword";
            this.TxtOldPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtOldPassword.TabIndex = 1;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(478, 24);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(67, 13);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "תעודת זהות";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(461, 55);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 3;
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Location = new System.Drawing.Point(602, 210);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(74, 13);
            this.LblNewPassword.TabIndex = 4;
            this.LblNewPassword.Text = "סיסמא חדשה";
            // 
            // LblconfirmPassword
            // 
            this.LblconfirmPassword.AutoSize = true;
            this.LblconfirmPassword.Location = new System.Drawing.Point(605, 279);
            this.LblconfirmPassword.Name = "LblconfirmPassword";
            this.LblconfirmPassword.Size = new System.Drawing.Size(110, 13);
            this.LblconfirmPassword.TabIndex = 5;
            this.LblconfirmPassword.Text = "אישור סיסמא חדשה";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(461, 210);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtNewPassword.TabIndex = 6;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(461, 279);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtConfirmPassword.TabIndex = 7;
            // 
            // ButConfirm
            // 
            this.ButConfirm.Location = new System.Drawing.Point(470, 361);
            this.ButConfirm.Name = "ButConfirm";
            this.ButConfirm.Size = new System.Drawing.Size(75, 23);
            this.ButConfirm.TabIndex = 8;
            this.ButConfirm.Text = "אישור";
            this.ButConfirm.UseVisualStyleBackColor = true;
            this.ButConfirm.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButConfirm);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.LblconfirmPassword);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TxtOldPassword);
            this.Controls.Add(this.LblOldpassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOldpassword;
        private System.Windows.Forms.TextBox TxtOldPassword;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.Label LblconfirmPassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Button ButConfirm;
    }
}