namespace AdministriranjeKorisnika
{
    partial class AdministratorsStatsForm
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
            this.korisniciDgv = new System.Windows.Forms.DataGridView();
            this.activateButton = new System.Windows.Forms.Button();
            this.deactivateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users:";
            // 
            // korisniciDgv
            // 
            this.korisniciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDgv.Location = new System.Drawing.Point(9, 38);
            this.korisniciDgv.Name = "korisniciDgv";
            this.korisniciDgv.Size = new System.Drawing.Size(771, 335);
            this.korisniciDgv.TabIndex = 1;
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(15, 397);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(100, 36);
            this.activateButton.TabIndex = 2;
            this.activateButton.Text = "Activate User";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // deactivateButton
            // 
            this.deactivateButton.Location = new System.Drawing.Point(121, 397);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(100, 36);
            this.deactivateButton.TabIndex = 3;
            this.deactivateButton.Text = "Deactivate User";
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // AdministratorsStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deactivateButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.korisniciDgv);
            this.Controls.Add(this.label1);
            this.Name = "AdministratorsStatsForm";
            this.Text = "Administrators stats form";
            this.Load += new System.EventHandler(this.AdministratorsStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView korisniciDgv;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Button deactivateButton;
    }
}