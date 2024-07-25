namespace College
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
            this.ButSignIn = new System.Windows.Forms.Button();
            this.ButSignUp = new System.Windows.Forms.Button();
            this.TxtPepelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButSignIn
            // 
            this.ButSignIn.Location = new System.Drawing.Point(142, 128);
            this.ButSignIn.Name = "ButSignIn";
            this.ButSignIn.Size = new System.Drawing.Size(75, 23);
            this.ButSignIn.TabIndex = 1;
            this.ButSignIn.Text = "Sign in";
            this.ButSignIn.UseVisualStyleBackColor = true;
            this.ButSignIn.Click += new System.EventHandler(this.ButSignIn_Click);
            // 
            // ButSignUp
            // 
            this.ButSignUp.Location = new System.Drawing.Point(142, 313);
            this.ButSignUp.Name = "ButSignUp";
            this.ButSignUp.Size = new System.Drawing.Size(75, 23);
            this.ButSignUp.TabIndex = 3;
            this.ButSignUp.Text = "Sign up";
            this.ButSignUp.UseVisualStyleBackColor = true;
            this.ButSignUp.Click += new System.EventHandler(this.ButSignUp_Click);
            // 
            // TxtPepelName
            // 
            this.TxtPepelName.Location = new System.Drawing.Point(368, 224);
            this.TxtPepelName.Name = "TxtPepelName";
            this.TxtPepelName.Size = new System.Drawing.Size(100, 20);
            this.TxtPepelName.TabIndex = 4;
            this.TxtPepelName.TextChanged += new System.EventHandler(this.TxtPepelName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "insert your name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPepelName);
            this.Controls.Add(this.ButSignUp);
            this.Controls.Add(this.ButSignIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSignIn;
        private System.Windows.Forms.Button ButSignUp;
        private System.Windows.Forms.TextBox TxtPepelName;
        private System.Windows.Forms.Label label1;
    }
}

