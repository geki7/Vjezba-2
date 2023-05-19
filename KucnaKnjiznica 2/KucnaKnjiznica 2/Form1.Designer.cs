namespace KucnaKnjiznica_2
{
    partial class Posudbe
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
            this.sveRbn = new System.Windows.Forms.RadioButton();
            this.trenutnePosudbeRbn = new System.Windows.Forms.RadioButton();
            this.proslePosudbeRbn = new System.Windows.Forms.RadioButton();
            this.popisDgv = new System.Windows.Forms.DataGridView();
            this.vratiKnjiguBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaži:";
            // 
            // sveRbn
            // 
            this.sveRbn.AutoSize = true;
            this.sveRbn.Location = new System.Drawing.Point(75, 28);
            this.sveRbn.Name = "sveRbn";
            this.sveRbn.Size = new System.Drawing.Size(88, 17);
            this.sveRbn.TabIndex = 1;
            this.sveRbn.TabStop = true;
            this.sveRbn.Text = "Sve posudbe";
            this.sveRbn.UseVisualStyleBackColor = true;
            this.sveRbn.CheckedChanged += new System.EventHandler(this.sveRbn_CheckedChanged);
            // 
            // trenutnePosudbeRbn
            // 
            this.trenutnePosudbeRbn.AutoSize = true;
            this.trenutnePosudbeRbn.Location = new System.Drawing.Point(185, 28);
            this.trenutnePosudbeRbn.Name = "trenutnePosudbeRbn";
            this.trenutnePosudbeRbn.Size = new System.Drawing.Size(112, 17);
            this.trenutnePosudbeRbn.TabIndex = 2;
            this.trenutnePosudbeRbn.TabStop = true;
            this.trenutnePosudbeRbn.Text = "Trenutne posudbe";
            this.trenutnePosudbeRbn.UseVisualStyleBackColor = true;
            this.trenutnePosudbeRbn.CheckedChanged += new System.EventHandler(this.trenutnePosudbeRbn_CheckedChanged);
            // 
            // proslePosudbeRbn
            // 
            this.proslePosudbeRbn.AutoSize = true;
            this.proslePosudbeRbn.Location = new System.Drawing.Point(301, 28);
            this.proslePosudbeRbn.Name = "proslePosudbeRbn";
            this.proslePosudbeRbn.Size = new System.Drawing.Size(98, 17);
            this.proslePosudbeRbn.TabIndex = 3;
            this.proslePosudbeRbn.TabStop = true;
            this.proslePosudbeRbn.Text = "Prošle posudbe";
            this.proslePosudbeRbn.UseVisualStyleBackColor = true;
            this.proslePosudbeRbn.CheckedChanged += new System.EventHandler(this.proslePosudbeRbn_CheckedChanged);
            // 
            // popisDgv
            // 
            this.popisDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisDgv.Location = new System.Drawing.Point(18, 64);
            this.popisDgv.Name = "popisDgv";
            this.popisDgv.Size = new System.Drawing.Size(727, 224);
            this.popisDgv.TabIndex = 4;
            // 
            // vratiKnjiguBtn
            // 
            this.vratiKnjiguBtn.Location = new System.Drawing.Point(642, 304);
            this.vratiKnjiguBtn.Name = "vratiKnjiguBtn";
            this.vratiKnjiguBtn.Size = new System.Drawing.Size(103, 33);
            this.vratiKnjiguBtn.TabIndex = 5;
            this.vratiKnjiguBtn.Text = "Vrati knjigu";
            this.vratiKnjiguBtn.UseVisualStyleBackColor = true;
            this.vratiKnjiguBtn.Click += new System.EventHandler(this.vratiKnjiguBtn_Click);
            // 
            // Posudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 353);
            this.Controls.Add(this.vratiKnjiguBtn);
            this.Controls.Add(this.popisDgv);
            this.Controls.Add(this.proslePosudbeRbn);
            this.Controls.Add(this.trenutnePosudbeRbn);
            this.Controls.Add(this.sveRbn);
            this.Controls.Add(this.label1);
            this.Name = "Posudbe";
            this.Text = "Posudbe";
            this.Load += new System.EventHandler(this.Posudbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sveRbn;
        private System.Windows.Forms.RadioButton trenutnePosudbeRbn;
        private System.Windows.Forms.RadioButton proslePosudbeRbn;
        private System.Windows.Forms.DataGridView popisDgv;
        private System.Windows.Forms.Button vratiKnjiguBtn;
    }
}

