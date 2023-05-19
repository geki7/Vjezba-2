namespace AutobusniKolodvorPopis
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
            this.cijenaTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.brojkarteTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vrstaKarteBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prtljagaCb = new System.Windows.Forms.CheckBox();
            this.povratnaCb = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentskaRb = new System.Windows.Forms.RadioButton();
            this.regularnaRb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odaberiBtn = new System.Windows.Forms.Button();
            this.autoprijevoznikTxtB = new System.Windows.Forms.TextBox();
            this.udaljenostTxb = new System.Windows.Forms.TextBox();
            this.odredisteTxtb = new System.Windows.Forms.TextBox();
            this.polazisteTxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cijenaTxb
            // 
            this.cijenaTxb.Location = new System.Drawing.Point(297, 472);
            this.cijenaTxb.Name = "cijenaTxb";
            this.cijenaTxb.Size = new System.Drawing.Size(139, 20);
            this.cijenaTxb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cijena karte:";
            // 
            // brojkarteTxb
            // 
            this.brojkarteTxb.Location = new System.Drawing.Point(70, 472);
            this.brojkarteTxb.Name = "brojkarteTxb";
            this.brojkarteTxb.Size = new System.Drawing.Size(139, 20);
            this.brojkarteTxb.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Broj karte:";
            // 
            // vrstaKarteBtn
            // 
            this.vrstaKarteBtn.Location = new System.Drawing.Point(12, 378);
            this.vrstaKarteBtn.Name = "vrstaKarteBtn";
            this.vrstaKarteBtn.Size = new System.Drawing.Size(155, 62);
            this.vrstaKarteBtn.TabIndex = 17;
            this.vrstaKarteBtn.Text = "Kreiraj kartu";
            this.vrstaKarteBtn.UseVisualStyleBackColor = true;
            this.vrstaKarteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prtljagaCb);
            this.groupBox3.Controls.Add(this.povratnaCb);
            this.groupBox3.Location = new System.Drawing.Point(12, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 50);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ostale opcije:";
            // 
            // prtljagaCb
            // 
            this.prtljagaCb.AutoSize = true;
            this.prtljagaCb.Location = new System.Drawing.Point(146, 19);
            this.prtljagaCb.Name = "prtljagaCb";
            this.prtljagaCb.Size = new System.Drawing.Size(61, 17);
            this.prtljagaCb.TabIndex = 1;
            this.prtljagaCb.Text = "Prtljaga";
            this.prtljagaCb.UseVisualStyleBackColor = true;
            // 
            // povratnaCb
            // 
            this.povratnaCb.AutoSize = true;
            this.povratnaCb.Location = new System.Drawing.Point(6, 19);
            this.povratnaCb.Name = "povratnaCb";
            this.povratnaCb.Size = new System.Drawing.Size(96, 17);
            this.povratnaCb.TabIndex = 0;
            this.povratnaCb.Text = "Povratna karta";
            this.povratnaCb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentskaRb);
            this.groupBox2.Controls.Add(this.regularnaRb);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 51);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrsta karte:";
            // 
            // studentskaRb
            // 
            this.studentskaRb.AutoSize = true;
            this.studentskaRb.Location = new System.Drawing.Point(146, 19);
            this.studentskaRb.Name = "studentskaRb";
            this.studentskaRb.Size = new System.Drawing.Size(106, 17);
            this.studentskaRb.TabIndex = 1;
            this.studentskaRb.TabStop = true;
            this.studentskaRb.Text = "Studentska karta";
            this.studentskaRb.UseVisualStyleBackColor = true;
            // 
            // regularnaRb
            // 
            this.regularnaRb.AutoSize = true;
            this.regularnaRb.Location = new System.Drawing.Point(6, 19);
            this.regularnaRb.Name = "regularnaRb";
            this.regularnaRb.Size = new System.Drawing.Size(101, 17);
            this.regularnaRb.TabIndex = 0;
            this.regularnaRb.TabStop = true;
            this.regularnaRb.Text = "Regularna karta";
            this.regularnaRb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odaberiBtn);
            this.groupBox1.Controls.Add(this.autoprijevoznikTxtB);
            this.groupBox1.Controls.Add(this.udaljenostTxb);
            this.groupBox1.Controls.Add(this.odredisteTxtb);
            this.groupBox1.Controls.Add(this.polazisteTxtB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 193);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autobusna linija";
            // 
            // odaberiBtn
            // 
            this.odaberiBtn.Location = new System.Drawing.Point(288, 22);
            this.odaberiBtn.Name = "odaberiBtn";
            this.odaberiBtn.Size = new System.Drawing.Size(155, 62);
            this.odaberiBtn.TabIndex = 8;
            this.odaberiBtn.Text = "Odaberite liniju";
            this.odaberiBtn.UseVisualStyleBackColor = true;
            this.odaberiBtn.Click += new System.EventHandler(this.odaberiBtn_Click);
            // 
            // autoprijevoznikTxtB
            // 
            this.autoprijevoznikTxtB.Location = new System.Drawing.Point(114, 145);
            this.autoprijevoznikTxtB.Name = "autoprijevoznikTxtB";
            this.autoprijevoznikTxtB.Size = new System.Drawing.Size(139, 20);
            this.autoprijevoznikTxtB.TabIndex = 7;
            // 
            // udaljenostTxb
            // 
            this.udaljenostTxb.Location = new System.Drawing.Point(114, 103);
            this.udaljenostTxb.Name = "udaljenostTxb";
            this.udaljenostTxb.Size = new System.Drawing.Size(58, 20);
            this.udaljenostTxb.TabIndex = 6;
            // 
            // odredisteTxtb
            // 
            this.odredisteTxtb.Location = new System.Drawing.Point(114, 64);
            this.odredisteTxtb.Name = "odredisteTxtb";
            this.odredisteTxtb.Size = new System.Drawing.Size(139, 20);
            this.odredisteTxtb.TabIndex = 5;
            // 
            // polazisteTxtB
            // 
            this.polazisteTxtB.Location = new System.Drawing.Point(114, 22);
            this.polazisteTxtB.Name = "polazisteTxtB";
            this.polazisteTxtB.Size = new System.Drawing.Size(139, 20);
            this.polazisteTxtB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autoprijevoznik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Udaljenost (km):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 531);
            this.Controls.Add(this.cijenaTxb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brojkarteTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vrstaKarteBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cijenaTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox brojkarteTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button vrstaKarteBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox prtljagaCb;
        private System.Windows.Forms.CheckBox povratnaCb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton studentskaRb;
        private System.Windows.Forms.RadioButton regularnaRb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button odaberiBtn;
        private System.Windows.Forms.TextBox autoprijevoznikTxtB;
        private System.Windows.Forms.TextBox udaljenostTxb;
        private System.Windows.Forms.TextBox odredisteTxtb;
        private System.Windows.Forms.TextBox polazisteTxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

