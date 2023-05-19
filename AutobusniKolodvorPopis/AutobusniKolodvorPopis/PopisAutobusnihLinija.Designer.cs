namespace AutobusniKolodvorPopis
{
    partial class PopisAutobusnihLinija
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
            this.popisLinijaDgv = new System.Windows.Forms.DataGridView();
            this.izlazBtn = new System.Windows.Forms.Button();
            this.odaberiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // popisLinijaDgv
            // 
            this.popisLinijaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisLinijaDgv.Location = new System.Drawing.Point(12, 48);
            this.popisLinijaDgv.Name = "popisLinijaDgv";
            this.popisLinijaDgv.Size = new System.Drawing.Size(523, 282);
            this.popisLinijaDgv.TabIndex = 0;
            this.popisLinijaDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.popisLinijaDgv_CellContentClick);
            // 
            // izlazBtn
            // 
            this.izlazBtn.Location = new System.Drawing.Point(440, 345);
            this.izlazBtn.Name = "izlazBtn";
            this.izlazBtn.Size = new System.Drawing.Size(95, 31);
            this.izlazBtn.TabIndex = 5;
            this.izlazBtn.Text = "Izlaz";
            this.izlazBtn.UseVisualStyleBackColor = true;
            this.izlazBtn.Click += new System.EventHandler(this.izlazBtn_Click);
            // 
            // odaberiBtn
            // 
            this.odaberiBtn.Location = new System.Drawing.Point(318, 345);
            this.odaberiBtn.Name = "odaberiBtn";
            this.odaberiBtn.Size = new System.Drawing.Size(95, 31);
            this.odaberiBtn.TabIndex = 4;
            this.odaberiBtn.Text = "Odaberi";
            this.odaberiBtn.UseVisualStyleBackColor = true;
            this.odaberiBtn.Click += new System.EventHandler(this.odaberiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Autobusnije linije";
            // 
            // PopisAutobusnihLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izlazBtn);
            this.Controls.Add(this.odaberiBtn);
            this.Controls.Add(this.popisLinijaDgv);
            this.Name = "PopisAutobusnihLinija";
            this.Text = "PopisAutobusnihLinija";
            this.Load += new System.EventHandler(this.PopisAutobusnihLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisLinijaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView popisLinijaDgv;
        private System.Windows.Forms.Button izlazBtn;
        private System.Windows.Forms.Button odaberiBtn;
        private System.Windows.Forms.Label label1;
    }
}