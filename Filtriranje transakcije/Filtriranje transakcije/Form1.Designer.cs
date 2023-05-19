namespace Filtriranje_transakcije
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.racunCbx = new System.Windows.Forms.ComboBox();
            this.uplateRbn = new System.Windows.Forms.RadioButton();
            this.isplateRbn = new System.Windows.Forms.RadioButton();
            this.sveRbn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrirajBtn = new System.Windows.Forms.Button();
            this.ocistiBtn = new System.Windows.Forms.Button();
            this.racuniListaDgv = new System.Windows.Forms.DataGridView();
            this.detaljiRacunabtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racuniListaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.racunCbx);
            this.groupBox1.Controls.Add(this.uplateRbn);
            this.groupBox1.Controls.Add(this.isplateRbn);
            this.groupBox1.Controls.Add(this.sveRbn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter: ";
            // 
            // racunCbx
            // 
            this.racunCbx.FormattingEnabled = true;
            this.racunCbx.Location = new System.Drawing.Point(54, 30);
            this.racunCbx.Name = "racunCbx";
            this.racunCbx.Size = new System.Drawing.Size(205, 21);
            this.racunCbx.TabIndex = 5;
            this.racunCbx.SelectedIndexChanged += new System.EventHandler(this.racunCbx_SelectedIndexChanged);
            // 
            // uplateRbn
            // 
            this.uplateRbn.AutoSize = true;
            this.uplateRbn.Location = new System.Drawing.Point(203, 87);
            this.uplateRbn.Name = "uplateRbn";
            this.uplateRbn.Size = new System.Drawing.Size(56, 17);
            this.uplateRbn.TabIndex = 4;
            this.uplateRbn.TabStop = true;
            this.uplateRbn.Text = "Uplate";
            this.uplateRbn.UseVisualStyleBackColor = true;
            // 
            // isplateRbn
            // 
            this.isplateRbn.AutoSize = true;
            this.isplateRbn.Location = new System.Drawing.Point(141, 87);
            this.isplateRbn.Name = "isplateRbn";
            this.isplateRbn.Size = new System.Drawing.Size(56, 17);
            this.isplateRbn.TabIndex = 3;
            this.isplateRbn.TabStop = true;
            this.isplateRbn.Text = "Isplate";
            this.isplateRbn.UseVisualStyleBackColor = true;
            // 
            // sveRbn
            // 
            this.sveRbn.AutoSize = true;
            this.sveRbn.Location = new System.Drawing.Point(91, 87);
            this.sveRbn.Name = "sveRbn";
            this.sveRbn.Size = new System.Drawing.Size(44, 17);
            this.sveRbn.TabIndex = 2;
            this.sveRbn.TabStop = true;
            this.sveRbn.Text = "Sve";
            this.sveRbn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip transakcije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // filtrirajBtn
            // 
            this.filtrirajBtn.Location = new System.Drawing.Point(324, 54);
            this.filtrirajBtn.Name = "filtrirajBtn";
            this.filtrirajBtn.Size = new System.Drawing.Size(126, 57);
            this.filtrirajBtn.TabIndex = 1;
            this.filtrirajBtn.Text = "Filtriraj";
            this.filtrirajBtn.UseVisualStyleBackColor = true;
            this.filtrirajBtn.Click += new System.EventHandler(this.filtrirajBtn_Click);
            // 
            // ocistiBtn
            // 
            this.ocistiBtn.Location = new System.Drawing.Point(456, 55);
            this.ocistiBtn.Name = "ocistiBtn";
            this.ocistiBtn.Size = new System.Drawing.Size(126, 57);
            this.ocistiBtn.TabIndex = 2;
            this.ocistiBtn.Text = "Očisti";
            this.ocistiBtn.UseVisualStyleBackColor = true;
            this.ocistiBtn.Click += new System.EventHandler(this.ocistiBtn_Click);
            // 
            // racuniListaDgv
            // 
            this.racuniListaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniListaDgv.Location = new System.Drawing.Point(12, 160);
            this.racuniListaDgv.Name = "racuniListaDgv";
            this.racuniListaDgv.Size = new System.Drawing.Size(569, 218);
            this.racuniListaDgv.TabIndex = 3;
            // 
            // detaljiRacunabtn
            // 
            this.detaljiRacunabtn.Location = new System.Drawing.Point(455, 384);
            this.detaljiRacunabtn.Name = "detaljiRacunabtn";
            this.detaljiRacunabtn.Size = new System.Drawing.Size(126, 57);
            this.detaljiRacunabtn.TabIndex = 4;
            this.detaljiRacunabtn.Text = "Detalji računa";
            this.detaljiRacunabtn.UseVisualStyleBackColor = true;
            this.detaljiRacunabtn.Click += new System.EventHandler(this.detaljiRacunabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.detaljiRacunabtn);
            this.Controls.Add(this.racuniListaDgv);
            this.Controls.Add(this.ocistiBtn);
            this.Controls.Add(this.filtrirajBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racuniListaDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox racunCbx;
        private System.Windows.Forms.RadioButton uplateRbn;
        private System.Windows.Forms.RadioButton isplateRbn;
        private System.Windows.Forms.RadioButton sveRbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtrirajBtn;
        private System.Windows.Forms.Button ocistiBtn;
        private System.Windows.Forms.DataGridView racuniListaDgv;
        private System.Windows.Forms.Button detaljiRacunabtn;
    }
}

