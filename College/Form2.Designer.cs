namespace College
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
            this.TxtChoiceCourse = new System.Windows.Forms.TextBox();
            this.ListBoxCourses = new System.Windows.Forms.ListBox();
            this.ButAddCourse = new System.Windows.Forms.Button();
            this.ButSignUpCourse = new System.Windows.Forms.Button();
            this.CoursesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtChoiceCourse
            // 
            this.TxtChoiceCourse.Location = new System.Drawing.Point(480, 124);
            this.TxtChoiceCourse.Name = "TxtChoiceCourse";
            this.TxtChoiceCourse.Size = new System.Drawing.Size(100, 20);
            this.TxtChoiceCourse.TabIndex = 0;
            this.TxtChoiceCourse.TextChanged += new System.EventHandler(this.TxtChoiceCourse_TextChanged);
            // 
            // ListBoxCourses
            // 
            this.ListBoxCourses.FormattingEnabled = true;
            this.ListBoxCourses.Location = new System.Drawing.Point(480, 256);
            this.ListBoxCourses.Name = "ListBoxCourses";
            this.ListBoxCourses.Size = new System.Drawing.Size(120, 95);
            this.ListBoxCourses.TabIndex = 1;
            this.ListBoxCourses.SelectedIndexChanged += new System.EventHandler(this.ListBoxCourses_SelectedIndexChanged);
            // 
            // ButAddCourse
            // 
            this.ButAddCourse.Location = new System.Drawing.Point(253, 327);
            this.ButAddCourse.Name = "ButAddCourse";
            this.ButAddCourse.Size = new System.Drawing.Size(75, 23);
            this.ButAddCourse.TabIndex = 2;
            this.ButAddCourse.Text = "Add";
            this.ButAddCourse.UseVisualStyleBackColor = true;
            this.ButAddCourse.Click += new System.EventHandler(this.ButAddCourse_Click);
            // 
            // ButSignUpCourse
            // 
            this.ButSignUpCourse.Location = new System.Drawing.Point(121, 327);
            this.ButSignUpCourse.Name = "ButSignUpCourse";
            this.ButSignUpCourse.Size = new System.Drawing.Size(75, 23);
            this.ButSignUpCourse.TabIndex = 3;
            this.ButSignUpCourse.Text = "Sign up";
            this.ButSignUpCourse.UseVisualStyleBackColor = true;
            this.ButSignUpCourse.Click += new System.EventHandler(this.ButSignUpCourse_Click);
            // 
            // CoursesLbl
            // 
            this.CoursesLbl.AutoSize = true;
            this.CoursesLbl.Location = new System.Drawing.Point(396, 51);
            this.CoursesLbl.Name = "CoursesLbl";
            this.CoursesLbl.Size = new System.Drawing.Size(45, 13);
            this.CoursesLbl.TabIndex = 4;
            this.CoursesLbl.Text = "Courses";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoursesLbl);
            this.Controls.Add(this.ButSignUpCourse);
            this.Controls.Add(this.ButAddCourse);
            this.Controls.Add(this.ListBoxCourses);
            this.Controls.Add(this.TxtChoiceCourse);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtChoiceCourse;
        private System.Windows.Forms.ListBox ListBoxCourses;
        private System.Windows.Forms.Button ButAddCourse;
        private System.Windows.Forms.Button ButSignUpCourse;
        private System.Windows.Forms.Label CoursesLbl;
    }
}