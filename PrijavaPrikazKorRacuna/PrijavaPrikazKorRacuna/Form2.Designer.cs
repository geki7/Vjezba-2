namespace PrijavaPrikazKorRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTxb = new System.Windows.Forms.TextBox();
            this.lastNameTxb = new System.Windows.Forms.TextBox();
            this.userNameTxb = new System.Windows.Forms.TextBox();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminRbn = new System.Windows.Forms.RadioButton();
            this.guestRbn = new System.Windows.Forms.RadioButton();
            this.employeeRbn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // firstNameTxb
            // 
            this.firstNameTxb.Enabled = false;
            this.firstNameTxb.Location = new System.Drawing.Point(97, 28);
            this.firstNameTxb.Name = "firstNameTxb";
            this.firstNameTxb.Size = new System.Drawing.Size(148, 20);
            this.firstNameTxb.TabIndex = 4;
            // 
            // lastNameTxb
            // 
            this.lastNameTxb.Enabled = false;
            this.lastNameTxb.Location = new System.Drawing.Point(97, 80);
            this.lastNameTxb.Name = "lastNameTxb";
            this.lastNameTxb.Size = new System.Drawing.Size(148, 20);
            this.lastNameTxb.TabIndex = 5;
            // 
            // userNameTxb
            // 
            this.userNameTxb.Enabled = false;
            this.userNameTxb.Location = new System.Drawing.Point(97, 165);
            this.userNameTxb.Name = "userNameTxb";
            this.userNameTxb.Size = new System.Drawing.Size(148, 20);
            this.userNameTxb.TabIndex = 6;
            // 
            // passwordTxb
            // 
            this.passwordTxb.Enabled = false;
            this.passwordTxb.Location = new System.Drawing.Point(97, 230);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.Size = new System.Drawing.Size(148, 20);
            this.passwordTxb.TabIndex = 7;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(211, 402);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(86, 36);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeRbn);
            this.groupBox1.Controls.Add(this.guestRbn);
            this.groupBox1.Controls.Add(this.adminRbn);
            this.groupBox1.Location = new System.Drawing.Point(97, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User type:";
            // 
            // adminRbn
            // 
            this.adminRbn.AutoSize = true;
            this.adminRbn.Location = new System.Drawing.Point(23, 19);
            this.adminRbn.Name = "adminRbn";
            this.adminRbn.Size = new System.Drawing.Size(85, 17);
            this.adminRbn.TabIndex = 0;
            this.adminRbn.TabStop = true;
            this.adminRbn.Text = "Administrator";
            this.adminRbn.UseVisualStyleBackColor = true;
            // 
            // guestRbn
            // 
            this.guestRbn.AutoSize = true;
            this.guestRbn.Location = new System.Drawing.Point(23, 42);
            this.guestRbn.Name = "guestRbn";
            this.guestRbn.Size = new System.Drawing.Size(53, 17);
            this.guestRbn.TabIndex = 1;
            this.guestRbn.TabStop = true;
            this.guestRbn.Text = "Guest";
            this.guestRbn.UseVisualStyleBackColor = true;
            // 
            // employeeRbn
            // 
            this.employeeRbn.AutoSize = true;
            this.employeeRbn.Location = new System.Drawing.Point(23, 65);
            this.employeeRbn.Name = "employeeRbn";
            this.employeeRbn.Size = new System.Drawing.Size(71, 17);
            this.employeeRbn.TabIndex = 2;
            this.employeeRbn.TabStop = true;
            this.employeeRbn.Text = "Employee";
            this.employeeRbn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.passwordTxb);
            this.Controls.Add(this.userNameTxb);
            this.Controls.Add(this.lastNameTxb);
            this.Controls.Add(this.firstNameTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "User profile";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTxb;
        private System.Windows.Forms.TextBox lastNameTxb;
        private System.Windows.Forms.TextBox userNameTxb;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton employeeRbn;
        private System.Windows.Forms.RadioButton guestRbn;
        private System.Windows.Forms.RadioButton adminRbn;
    }
}