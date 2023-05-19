namespace ProvedbaiSortiranjeTransakcija
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
            this.iznosTxb = new System.Windows.Forms.TextBox();
            this.platiteljCbx = new System.Windows.Forms.ComboBox();
            this.primateljCbx = new System.Windows.Forms.ComboBox();
            this.provediBtn = new System.Windows.Forms.Button();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platitelj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primatelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iznos:";
            // 
            // iznosTxb
            // 
            this.iznosTxb.Location = new System.Drawing.Point(101, 132);
            this.iznosTxb.Name = "iznosTxb";
            this.iznosTxb.Size = new System.Drawing.Size(156, 20);
            this.iznosTxb.TabIndex = 3;
            // 
            // platiteljCbx
            // 
            this.platiteljCbx.FormattingEnabled = true;
            this.platiteljCbx.Location = new System.Drawing.Point(101, 22);
            this.platiteljCbx.Name = "platiteljCbx";
            this.platiteljCbx.Size = new System.Drawing.Size(156, 21);
            this.platiteljCbx.TabIndex = 4;
            // 
            // primateljCbx
            // 
            this.primateljCbx.FormattingEnabled = true;
            this.primateljCbx.Location = new System.Drawing.Point(101, 73);
            this.primateljCbx.Name = "primateljCbx";
            this.primateljCbx.Size = new System.Drawing.Size(156, 21);
            this.primateljCbx.TabIndex = 5;
            // 
            // provediBtn
            // 
            this.provediBtn.Location = new System.Drawing.Point(101, 173);
            this.provediBtn.Name = "provediBtn";
            this.provediBtn.Size = new System.Drawing.Size(75, 23);
            this.provediBtn.TabIndex = 6;
            this.provediBtn.Text = "Provedi";
            this.provediBtn.UseVisualStyleBackColor = true;
            this.provediBtn.Click += new System.EventHandler(this.provediBtn_Click);
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(182, 173);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(75, 23);
            this.odustaniBtn.TabIndex = 7;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 220);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.provediBtn);
            this.Controls.Add(this.primateljCbx);
            this.Controls.Add(this.platiteljCbx);
            this.Controls.Add(this.iznosTxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provedi transakciju";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iznosTxb;
        private System.Windows.Forms.ComboBox platiteljCbx;
        private System.Windows.Forms.ComboBox primateljCbx;
        private System.Windows.Forms.Button provediBtn;
        private System.Windows.Forms.Button odustaniBtn;
    }
}