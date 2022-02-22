namespace Learning_management_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.instructor = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 78);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learning management system - Home page";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(464, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // instructor
            // 
            this.instructor.BackColor = System.Drawing.Color.White;
            this.instructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructor.Location = new System.Drawing.Point(466, 345);
            this.instructor.Name = "instructor";
            this.instructor.Size = new System.Drawing.Size(201, 65);
            this.instructor.TabIndex = 3;
            this.instructor.Text = "Instructor";
            this.instructor.UseVisualStyleBackColor = false;
            this.instructor.Click += new System.EventHandler(this.instructor_Click);
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.White;
            this.student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student.Location = new System.Drawing.Point(466, 440);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(201, 65);
            this.student.TabIndex = 4;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = false;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(205, 628);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(133, 65);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(498, 628);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(133, 65);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.White;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Location = new System.Drawing.Point(794, 628);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(149, 65);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.student);
            this.Controls.Add(this.instructor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button instructor;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}

