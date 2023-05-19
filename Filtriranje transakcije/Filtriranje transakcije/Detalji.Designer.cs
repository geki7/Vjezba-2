namespace Filtriranje_transakcije
{
    partial class Detalji
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
            this.ibanTxb = new System.Windows.Forms.TextBox();
            this.vlasnikTxb = new System.Windows.Forms.TextBox();
            this.stanjeTxb = new System.Windows.Forms.TextBox();
            this.ukupniPrometTxb = new System.Windows.Forms.TextBox();
            this.zatvoriBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni promet:";
            // 
            // ibanTxb
            // 
            this.ibanTxb.Location = new System.Drawing.Point(138, 41);
            this.ibanTxb.Name = "ibanTxb";
            this.ibanTxb.Size = new System.Drawing.Size(149, 20);
            this.ibanTxb.TabIndex = 4;
            // 
            // vlasnikTxb
            // 
            this.vlasnikTxb.Location = new System.Drawing.Point(138, 88);
            this.vlasnikTxb.Name = "vlasnikTxb";
            this.vlasnikTxb.Size = new System.Drawing.Size(149, 20);
            this.vlasnikTxb.TabIndex = 5;
            // 
            // stanjeTxb
            // 
            this.stanjeTxb.Location = new System.Drawing.Point(138, 182);
            this.stanjeTxb.Name = "stanjeTxb";
            this.stanjeTxb.Size = new System.Drawing.Size(149, 20);
            this.stanjeTxb.TabIndex = 6;
            // 
            // ukupniPrometTxb
            // 
            this.ukupniPrometTxb.Location = new System.Drawing.Point(138, 239);
            this.ukupniPrometTxb.Name = "ukupniPrometTxb";
            this.ukupniPrometTxb.Size = new System.Drawing.Size(149, 20);
            this.ukupniPrometTxb.TabIndex = 7;
            // 
            // zatvoriBtn
            // 
            this.zatvoriBtn.Location = new System.Drawing.Point(198, 293);
            this.zatvoriBtn.Name = "zatvoriBtn";
            this.zatvoriBtn.Size = new System.Drawing.Size(89, 44);
            this.zatvoriBtn.TabIndex = 8;
            this.zatvoriBtn.Text = "Zatvori";
            this.zatvoriBtn.UseVisualStyleBackColor = true;
            this.zatvoriBtn.Click += new System.EventHandler(this.zatvoriBtn_Click);
            // 
            // Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 353);
            this.Controls.Add(this.zatvoriBtn);
            this.Controls.Add(this.ukupniPrometTxb);
            this.Controls.Add(this.stanjeTxb);
            this.Controls.Add(this.vlasnikTxb);
            this.Controls.Add(this.ibanTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Detalji";
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.Detalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ibanTxb;
        private System.Windows.Forms.TextBox vlasnikTxb;
        private System.Windows.Forms.TextBox stanjeTxb;
        private System.Windows.Forms.TextBox ukupniPrometTxb;
        private System.Windows.Forms.Button zatvoriBtn;
    }
}