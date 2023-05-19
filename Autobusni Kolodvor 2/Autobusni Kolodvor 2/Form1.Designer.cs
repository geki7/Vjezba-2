namespace Autobusni_Kolodvor_2
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
            this.pronadiBtn = new System.Windows.Forms.Button();
            this.odredisteTxb = new System.Windows.Forms.TextBox();
            this.kupiKartuBtn = new System.Windows.Forms.Button();
            this.autobuslinijaDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.osvjeziBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autobuslinijaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pronadiBtn
            // 
            this.pronadiBtn.Location = new System.Drawing.Point(237, 17);
            this.pronadiBtn.Name = "pronadiBtn";
            this.pronadiBtn.Size = new System.Drawing.Size(107, 36);
            this.pronadiBtn.TabIndex = 9;
            this.pronadiBtn.Text = "Pronađi";
            this.pronadiBtn.UseVisualStyleBackColor = true;
            this.pronadiBtn.Click += new System.EventHandler(this.pronadiBtn_Click);
            // 
            // odredisteTxb
            // 
            this.odredisteTxb.Location = new System.Drawing.Point(67, 26);
            this.odredisteTxb.Name = "odredisteTxb";
            this.odredisteTxb.Size = new System.Drawing.Size(164, 20);
            this.odredisteTxb.TabIndex = 8;
            // 
            // kupiKartuBtn
            // 
            this.kupiKartuBtn.Location = new System.Drawing.Point(642, 376);
            this.kupiKartuBtn.Name = "kupiKartuBtn";
            this.kupiKartuBtn.Size = new System.Drawing.Size(107, 36);
            this.kupiKartuBtn.TabIndex = 7;
            this.kupiKartuBtn.Text = "Kupi kartu";
            this.kupiKartuBtn.UseVisualStyleBackColor = true;
            this.kupiKartuBtn.Click += new System.EventHandler(this.kupiKartuBtn_Click);
            // 
            // autobuslinijaDgv
            // 
            this.autobuslinijaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autobuslinijaDgv.Location = new System.Drawing.Point(12, 64);
            this.autobuslinijaDgv.Name = "autobuslinijaDgv";
            this.autobuslinijaDgv.Size = new System.Drawing.Size(737, 306);
            this.autobuslinijaDgv.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Odredište:";
            // 
            // osvjeziBtn
            // 
            this.osvjeziBtn.Location = new System.Drawing.Point(350, 17);
            this.osvjeziBtn.Name = "osvjeziBtn";
            this.osvjeziBtn.Size = new System.Drawing.Size(107, 36);
            this.osvjeziBtn.TabIndex = 10;
            this.osvjeziBtn.Text = "Osvježi";
            this.osvjeziBtn.UseVisualStyleBackColor = true;
            this.osvjeziBtn.Click += new System.EventHandler(this.osvjeziBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 439);
            this.Controls.Add(this.osvjeziBtn);
            this.Controls.Add(this.pronadiBtn);
            this.Controls.Add(this.odredisteTxb);
            this.Controls.Add(this.kupiKartuBtn);
            this.Controls.Add(this.autobuslinijaDgv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autobusne linije";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autobuslinijaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pronadiBtn;
        private System.Windows.Forms.TextBox odredisteTxb;
        private System.Windows.Forms.Button kupiKartuBtn;
        private System.Windows.Forms.DataGridView autobuslinijaDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button osvjeziBtn;
    }
}

