namespace NogometnoPrvenstvo
{
    partial class DodajUtakmicuForm
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
            this.domacinComboBox = new System.Windows.Forms.ComboBox();
            this.zgodiciDomacinTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gostComboBox = new System.Windows.Forms.ComboBox();
            this.zgodiciGostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zakazanaRadio = new System.Windows.Forms.RadioButton();
            this.odigranaRadio = new System.Windows.Forms.RadioButton();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaćin";
            // 
            // domacinComboBox
            // 
            this.domacinComboBox.FormattingEnabled = true;
            this.domacinComboBox.Location = new System.Drawing.Point(25, 45);
            this.domacinComboBox.Name = "domacinComboBox";
            this.domacinComboBox.Size = new System.Drawing.Size(121, 21);
            this.domacinComboBox.TabIndex = 1;
            // 
            // zgodiciDomacinTextBox
            // 
            this.zgodiciDomacinTextBox.Location = new System.Drawing.Point(179, 46);
            this.zgodiciDomacinTextBox.Name = "zgodiciDomacinTextBox";
            this.zgodiciDomacinTextBox.Size = new System.Drawing.Size(100, 20);
            this.zgodiciDomacinTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gostComboBox
            // 
            this.gostComboBox.FormattingEnabled = true;
            this.gostComboBox.Location = new System.Drawing.Point(25, 106);
            this.gostComboBox.Name = "gostComboBox";
            this.gostComboBox.Size = new System.Drawing.Size(121, 21);
            this.gostComboBox.TabIndex = 4;
            // 
            // zgodiciGostTextBox
            // 
            this.zgodiciGostTextBox.Location = new System.Drawing.Point(179, 106);
            this.zgodiciGostTextBox.Name = "zgodiciGostTextBox";
            this.zgodiciGostTextBox.Size = new System.Drawing.Size(100, 20);
            this.zgodiciGostTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj zgoditaka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj zgoditaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum:";
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(25, 180);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(100, 20);
            this.datumTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odigranaRadio);
            this.groupBox1.Controls.Add(this.zakazanaRadio);
            this.groupBox1.Location = new System.Drawing.Point(25, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status utakmice";
            // 
            // zakazanaRadio
            // 
            this.zakazanaRadio.AutoSize = true;
            this.zakazanaRadio.Location = new System.Drawing.Point(20, 28);
            this.zakazanaRadio.Name = "zakazanaRadio";
            this.zakazanaRadio.Size = new System.Drawing.Size(73, 17);
            this.zakazanaRadio.TabIndex = 0;
            this.zakazanaRadio.TabStop = true;
            this.zakazanaRadio.Text = "Zakazana";
            this.zakazanaRadio.UseVisualStyleBackColor = true;
            // 
            // odigranaRadio
            // 
            this.odigranaRadio.AutoSize = true;
            this.odigranaRadio.Location = new System.Drawing.Point(137, 28);
            this.odigranaRadio.Name = "odigranaRadio";
            this.odigranaRadio.Size = new System.Drawing.Size(68, 17);
            this.odigranaRadio.TabIndex = 1;
            this.odigranaRadio.TabStop = true;
            this.odigranaRadio.Text = "Odigrana";
            this.odigranaRadio.UseVisualStyleBackColor = true;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(25, 326);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(93, 48);
            this.spremiButton.TabIndex = 11;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(186, 326);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(93, 48);
            this.odustaniButton.TabIndex = 12;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // DodajUtakmicuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 386);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zgodiciGostTextBox);
            this.Controls.Add(this.gostComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zgodiciDomacinTextBox);
            this.Controls.Add(this.domacinComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DodajUtakmicuForm";
            this.Text = "Dodaj utakmicu";
            this.Load += new System.EventHandler(this.DodajUtakmicuForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox domacinComboBox;
        private System.Windows.Forms.TextBox zgodiciDomacinTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gostComboBox;
        private System.Windows.Forms.TextBox zgodiciGostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton odigranaRadio;
        private System.Windows.Forms.RadioButton zakazanaRadio;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}