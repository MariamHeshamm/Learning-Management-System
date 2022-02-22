namespace Learning_Management_System
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.textBoxPasswordConfirm);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.buttonCreateAccount);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 744);
            this.panel1.TabIndex = 1;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.White;
            this.buttonCreateAccount.Location = new System.Drawing.Point(70, 559);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(704, 67);
            this.buttonCreateAccount.TabIndex = 5;
            this.buttonCreateAccount.Text = "CREATE ACCOUNT";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(70, 388);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(704, 51);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "password";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstname.Location = new System.Drawing.Point(70, 185);
            this.textBoxFirstname.Multiline = true;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(337, 57);
            this.textBoxFirstname.TabIndex = 200;
            this.textBoxFirstname.Text = "first name";
            this.textBoxFirstname.Enter += new System.EventHandler(this.textBoxFirstname_Enter);
            this.textBoxFirstname.Leave += new System.EventHandler(this.textBoxFirstname_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-11, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 145);
            this.panel2.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(831, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 32);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "X";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 145);
            this.label1.TabIndex = 1;
            this.label1.Text = "CREATE YOUR ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastname.Location = new System.Drawing.Point(434, 185);
            this.textBoxLastname.Multiline = true;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(340, 57);
            this.textBoxLastname.TabIndex = 6;
            this.textBoxLastname.Text = "last name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(70, 260);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(704, 47);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = "email address";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(70, 325);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(704, 47);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.Text = "username";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(70, 461);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(704, 51);
            this.textBoxPasswordConfirm.TabIndex = 9;
            this.textBoxPasswordConfirm.Text = "confirm password";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 744);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastname;
    }
}