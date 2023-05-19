namespace ProvedbaiSortiranjeTransakcija
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
            this.popistransDgv = new System.Windows.Forms.DataGridView();
            this.stornirajBtn = new System.Windows.Forms.Button();
            this.provediBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popistransDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // popistransDgv
            // 
            this.popistransDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popistransDgv.Location = new System.Drawing.Point(20, 23);
            this.popistransDgv.Name = "popistransDgv";
            this.popistransDgv.Size = new System.Drawing.Size(594, 265);
            this.popistransDgv.TabIndex = 0;
            // 
            // stornirajBtn
            // 
            this.stornirajBtn.Location = new System.Drawing.Point(436, 294);
            this.stornirajBtn.Name = "stornirajBtn";
            this.stornirajBtn.Size = new System.Drawing.Size(86, 59);
            this.stornirajBtn.TabIndex = 1;
            this.stornirajBtn.Text = "Storniraj transakciju";
            this.stornirajBtn.UseVisualStyleBackColor = true;
            this.stornirajBtn.Click += new System.EventHandler(this.stornirajBtn_Click);
            // 
            // provediBtn
            // 
            this.provediBtn.Location = new System.Drawing.Point(528, 294);
            this.provediBtn.Name = "provediBtn";
            this.provediBtn.Size = new System.Drawing.Size(86, 59);
            this.provediBtn.TabIndex = 2;
            this.provediBtn.Text = "Provedi transakciju";
            this.provediBtn.UseVisualStyleBackColor = true;
            this.provediBtn.Click += new System.EventHandler(this.provediBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 366);
            this.Controls.Add(this.provediBtn);
            this.Controls.Add(this.stornirajBtn);
            this.Controls.Add(this.popistransDgv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popistransDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView popistransDgv;
        private System.Windows.Forms.Button stornirajBtn;
        private System.Windows.Forms.Button provediBtn;
    }
}

