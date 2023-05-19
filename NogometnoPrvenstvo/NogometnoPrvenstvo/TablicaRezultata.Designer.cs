namespace NogometnoPrvenstvo
{
    partial class TablicaRezultata
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
            this.utakmiceGridView = new System.Windows.Forms.DataGridView();
            this.dodajButton = new System.Windows.Forms.Button();
            this.izmjeniButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.utakmiceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raspored utakmica";
            // 
            // utakmiceGridView
            // 
            this.utakmiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utakmiceGridView.Location = new System.Drawing.Point(9, 38);
            this.utakmiceGridView.Name = "utakmiceGridView";
            this.utakmiceGridView.Size = new System.Drawing.Size(765, 371);
            this.utakmiceGridView.TabIndex = 1;
            this.utakmiceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(435, 415);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(109, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj utakmicu";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // izmjeniButton
            // 
            this.izmjeniButton.Location = new System.Drawing.Point(550, 415);
            this.izmjeniButton.Name = "izmjeniButton";
            this.izmjeniButton.Size = new System.Drawing.Size(109, 23);
            this.izmjeniButton.TabIndex = 3;
            this.izmjeniButton.Text = "Izmjeni utakmicu";
            this.izmjeniButton.UseVisualStyleBackColor = true;
            this.izmjeniButton.Click += new System.EventHandler(this.izmjeniButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(665, 415);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(109, 23);
            this.obrisiButton.TabIndex = 4;
            this.obrisiButton.Text = "Obriši utakmicu";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // TablicaRezultata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.izmjeniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.utakmiceGridView);
            this.Controls.Add(this.label1);
            this.Name = "TablicaRezultata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablica rezultata";
            this.Load += new System.EventHandler(this.TablicaRezultata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utakmiceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView utakmiceGridView;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button izmjeniButton;
        private System.Windows.Forms.Button obrisiButton;
    }
}

