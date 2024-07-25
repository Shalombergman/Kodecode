namespace host
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labCategorey = new System.Windows.Forms.Label();
            this.ButRight = new System.Windows.Forms.Button();
            this.ButLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // labCategorey
            // 
            this.labCategorey.AutoSize = true;
            this.labCategorey.Location = new System.Drawing.Point(426, 96);
            this.labCategorey.Name = "labCategorey";
            this.labCategorey.Size = new System.Drawing.Size(35, 13);
            this.labCategorey.TabIndex = 1;
            this.labCategorey.Text = "label1";
            this.labCategorey.Click += new System.EventHandler(this.labCategorey_Click);
            // 
            // ButRight
            // 
            this.ButRight.Location = new System.Drawing.Point(564, 402);
            this.ButRight.Name = "ButRight";
            this.ButRight.Size = new System.Drawing.Size(75, 23);
            this.ButRight.TabIndex = 2;
            this.ButRight.Text = ">>>";
            this.ButRight.UseVisualStyleBackColor = true;
            this.ButRight.Click += new System.EventHandler(this.ButRight_Click);
            // 
            // ButLeft
            // 
            this.ButLeft.Location = new System.Drawing.Point(242, 402);
            this.ButLeft.Name = "ButLeft";
            this.ButLeft.Size = new System.Drawing.Size(75, 23);
            this.ButLeft.TabIndex = 3;
            this.ButLeft.Text = "<<<";
            this.ButLeft.UseVisualStyleBackColor = true;
            this.ButLeft.Click += new System.EventHandler(this.ButLeft_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButLeft);
            this.Controls.Add(this.ButRight);
            this.Controls.Add(this.labCategorey);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labCategorey;
        private System.Windows.Forms.Button ButRight;
        private System.Windows.Forms.Button ButLeft;
    }
}