namespace KucnaKnjiznica1
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
            this.isbnTxb = new System.Windows.Forms.TextBox();
            this.osobaTxb = new System.Windows.Forms.TextBox();
            this.naslovTxb = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osoba:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // isbnTxb
            // 
            this.isbnTxb.Location = new System.Drawing.Point(79, 30);
            this.isbnTxb.Name = "isbnTxb";
            this.isbnTxb.Size = new System.Drawing.Size(166, 20);
            this.isbnTxb.TabIndex = 3;
            // 
            // osobaTxb
            // 
            this.osobaTxb.Location = new System.Drawing.Point(79, 160);
            this.osobaTxb.Name = "osobaTxb";
            this.osobaTxb.Size = new System.Drawing.Size(166, 20);
            this.osobaTxb.TabIndex = 4;
            // 
            // naslovTxb
            // 
            this.naslovTxb.Location = new System.Drawing.Point(79, 93);
            this.naslovTxb.Name = "naslovTxb";
            this.naslovTxb.Size = new System.Drawing.Size(166, 20);
            this.naslovTxb.TabIndex = 5;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(79, 202);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 27);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "U redu";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(165, 202);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(80, 27);
            this.odustaniBtn.TabIndex = 7;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 334);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.naslovTxb);
            this.Controls.Add(this.osobaTxb);
            this.Controls.Add(this.isbnTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Nova posudba";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnTxb;
        private System.Windows.Forms.TextBox osobaTxb;
        private System.Windows.Forms.TextBox naslovTxb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button odustaniBtn;
    }
}