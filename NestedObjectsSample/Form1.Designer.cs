namespace NestedObjectsSample
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
            this.lstInstructors = new System.Windows.Forms.ListBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstInstructors
            // 
            this.lstInstructors.FormattingEnabled = true;
            this.lstInstructors.Location = new System.Drawing.Point(12, 44);
            this.lstInstructors.Name = "lstInstructors";
            this.lstInstructors.Size = new System.Drawing.Size(254, 186);
            this.lstInstructors.TabIndex = 0;
            this.lstInstructors.SelectedIndexChanged += new System.EventHandler(this.lstInstructors_SelectedIndexChanged);
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(270, 44);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(254, 186);
            this.lstCourses.TabIndex = 1;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(534, 44);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(254, 186);
            this.lstStudents.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 282);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lstInstructors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInstructors;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.ListBox lstStudents;
    }
}

