namespace KucnaKnjiznica1
{
    partial class Knjige
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
            this.dostupneKnjigeDgv = new System.Windows.Forms.DataGridView();
            this.posudiKnjiguBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.posudbaDgv = new System.Windows.Forms.DataGridView();
            this.vratiKnjiguBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dostupneKnjigeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudbaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostupne knjige:";
            // 
            // dostupneKnjigeDgv
            // 
            this.dostupneKnjigeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dostupneKnjigeDgv.Location = new System.Drawing.Point(15, 35);
            this.dostupneKnjigeDgv.Name = "dostupneKnjigeDgv";
            this.dostupneKnjigeDgv.Size = new System.Drawing.Size(301, 234);
            this.dostupneKnjigeDgv.TabIndex = 1;
            // 
            // posudiKnjiguBtn
            // 
            this.posudiKnjiguBtn.Location = new System.Drawing.Point(219, 284);
            this.posudiKnjiguBtn.Name = "posudiKnjiguBtn";
            this.posudiKnjiguBtn.Size = new System.Drawing.Size(97, 29);
            this.posudiKnjiguBtn.TabIndex = 2;
            this.posudiKnjiguBtn.Text = "Posudi knjigu";
            this.posudiKnjiguBtn.UseVisualStyleBackColor = true;
            this.posudiKnjiguBtn.Click += new System.EventHandler(this.posudiKnjiguBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Knjige na posudbi:";
            // 
            // posudbaDgv
            // 
            this.posudbaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posudbaDgv.Location = new System.Drawing.Point(15, 368);
            this.posudbaDgv.Name = "posudbaDgv";
            this.posudbaDgv.Size = new System.Drawing.Size(301, 140);
            this.posudbaDgv.TabIndex = 4;
            // 
            // vratiKnjiguBtn
            // 
            this.vratiKnjiguBtn.Location = new System.Drawing.Point(219, 525);
            this.vratiKnjiguBtn.Name = "vratiKnjiguBtn";
            this.vratiKnjiguBtn.Size = new System.Drawing.Size(97, 29);
            this.vratiKnjiguBtn.TabIndex = 5;
            this.vratiKnjiguBtn.Text = "Vrati knjigu";
            this.vratiKnjiguBtn.UseVisualStyleBackColor = true;
            this.vratiKnjiguBtn.Click += new System.EventHandler(this.vratiKnjiguBtn_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 574);
            this.Controls.Add(this.vratiKnjiguBtn);
            this.Controls.Add(this.posudbaDgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posudiKnjiguBtn);
            this.Controls.Add(this.dostupneKnjigeDgv);
            this.Controls.Add(this.label1);
            this.Name = "Knjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dostupneKnjigeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudbaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dostupneKnjigeDgv;
        private System.Windows.Forms.Button posudiKnjiguBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView posudbaDgv;
        private System.Windows.Forms.Button vratiKnjiguBtn;
    }
}

