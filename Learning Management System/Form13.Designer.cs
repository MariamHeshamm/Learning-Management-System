namespace Learning_management_system
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1182, 78);
            this.panel1.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(1154, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learning management system - Admin - Delete courses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.Gray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 46;
            this.listBox1.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Forth"});
            this.listBox1.Location = new System.Drawing.Point(294, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(548, 4);
            this.listBox1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(288, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(705, 38);
            this.label8.TabIndex = 33;
            this.label8.Text = "Choose the grade you will delete a course from:";
            // 
            // listBox2
            // 
            this.listBox2.ForeColor = System.Drawing.Color.Gray;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 46;
            this.listBox2.Items.AddRange(new object[] {
            "Introduction to computers",
            "Maths 1",
            "Physics 1",
            "English 1",
            "Humanities",
            "Liguistics",
            "Maths 2",
            "Physics 2",
            "Structured programming",
            "Eloctronics",
            "English 2",
            "Management"});
            this.listBox2.Location = new System.Drawing.Point(294, 457);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(560, 4);
            this.listBox2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 41);
            this.label6.TabIndex = 35;
            this.label6.Text = "Choose the course you will delete:";
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.Color.Gray;
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(294, 547);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(554, 65);
            this.submit.TabIndex = 37;
            this.submit.Text = "Delete";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.ForeColor = System.Drawing.Color.Gray;
            this.back.Location = new System.Drawing.Point(31, 587);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(201, 65);
            this.back.TabIndex = 38;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form13
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.back);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button back;
    }
}