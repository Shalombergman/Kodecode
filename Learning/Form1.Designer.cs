namespace Learning
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButOperatorAritmeti = new System.Windows.Forms.Button();
            this.ButDog = new System.Windows.Forms.Button();
            this.ButDo = new System.Windows.Forms.Button();
            this.ButPrint = new System.Windows.Forms.Button();
            this.BtnPersonAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "StringArr";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "print student arry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "lbl Student";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButOperatorAritmeti
            // 
            this.ButOperatorAritmeti.Location = new System.Drawing.Point(656, 258);
            this.ButOperatorAritmeti.Name = "ButOperatorAritmeti";
            this.ButOperatorAritmeti.Size = new System.Drawing.Size(75, 23);
            this.ButOperatorAritmeti.TabIndex = 5;
            this.ButOperatorAritmeti.Text = "operatorAritmeti";
            this.ButOperatorAritmeti.UseVisualStyleBackColor = true;
            this.ButOperatorAritmeti.Click += new System.EventHandler(this.ButOperatorAritmeti_Click);
            // 
            // ButDog
            // 
            this.ButDog.Location = new System.Drawing.Point(615, 333);
            this.ButDog.Name = "ButDog";
            this.ButDog.Size = new System.Drawing.Size(75, 23);
            this.ButDog.TabIndex = 6;
            this.ButDog.Text = "Dog";
            this.ButDog.UseVisualStyleBackColor = true;
            // 
            // ButDo
            // 
            this.ButDo.Location = new System.Drawing.Point(405, 333);
            this.ButDo.Name = "ButDo";
            this.ButDo.Size = new System.Drawing.Size(75, 23);
            this.ButDo.TabIndex = 7;
            this.ButDo.Text = "אתחול כלבים";
            this.ButDo.UseVisualStyleBackColor = true;
            this.ButDo.Click += new System.EventHandler(this.ButDo_Click);
            // 
            // ButPrint
            // 
            this.ButPrint.Location = new System.Drawing.Point(265, 333);
            this.ButPrint.Name = "ButPrint";
            this.ButPrint.Size = new System.Drawing.Size(75, 23);
            this.ButPrint.TabIndex = 8;
            this.ButPrint.Text = "הדפסת כלבים";
            this.ButPrint.UseVisualStyleBackColor = true;
            this.ButPrint.Click += new System.EventHandler(this.ButPrint_Click);
            // 
            // BtnPersonAge
            // 
            this.BtnPersonAge.Location = new System.Drawing.Point(616, 401);
            this.BtnPersonAge.Name = "BtnPersonAge";
            this.BtnPersonAge.Size = new System.Drawing.Size(75, 23);
            this.BtnPersonAge.TabIndex = 9;
            this.BtnPersonAge.Text = "PersonAge";
            this.BtnPersonAge.UseVisualStyleBackColor = true;
            this.BtnPersonAge.Click += new System.EventHandler(this.BtnPersonAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPersonAge);
            this.Controls.Add(this.ButPrint);
            this.Controls.Add(this.ButDo);
            this.Controls.Add(this.ButDog);
            this.Controls.Add(this.ButOperatorAritmeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButOperatorAritmeti;
        private System.Windows.Forms.Button ButDog;
        private System.Windows.Forms.Button ButDo;
        private System.Windows.Forms.Button ButPrint;
        private System.Windows.Forms.Button BtnPersonAge;
    }
}

