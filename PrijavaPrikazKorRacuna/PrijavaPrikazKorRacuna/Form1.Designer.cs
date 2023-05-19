namespace PrijavaPrikazKorRacuna
{
    partial class Login
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
            this.usernameTxb = new System.Windows.Forms.TextBox();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.lloginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usernameTxb
            // 
            this.usernameTxb.Location = new System.Drawing.Point(15, 63);
            this.usernameTxb.Name = "usernameTxb";
            this.usernameTxb.Size = new System.Drawing.Size(167, 20);
            this.usernameTxb.TabIndex = 2;
            // 
            // passwordTxb
            // 
            this.passwordTxb.Location = new System.Drawing.Point(15, 152);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.PasswordChar = '*';
            this.passwordTxb.Size = new System.Drawing.Size(167, 20);
            this.passwordTxb.TabIndex = 3;
            // 
            // lloginBtn
            // 
            this.lloginBtn.Location = new System.Drawing.Point(107, 196);
            this.lloginBtn.Name = "lloginBtn";
            this.lloginBtn.Size = new System.Drawing.Size(75, 23);
            this.lloginBtn.TabIndex = 4;
            this.lloginBtn.Text = "Log In";
            this.lloginBtn.UseVisualStyleBackColor = true;
            this.lloginBtn.Click += new System.EventHandler(this.lloginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 234);
            this.Controls.Add(this.lloginBtn);
            this.Controls.Add(this.passwordTxb);
            this.Controls.Add(this.usernameTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxb;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Button lloginBtn;
    }
}

