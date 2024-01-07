namespace OkulAppSube1BIL
{
    partial class frmOgrBul
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.btnARA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumara);
            this.groupBox1.Controls.Add(this.btnARA);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bulma Ekranı ";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(100, 112);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(119, 20);
            this.txtNumara.TabIndex = 0;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(97, 82);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(122, 13);
            this.lblNumara.TabIndex = 1;
            this.lblNumara.Text = "Öğrenci Numarası Giriniz";
            // 
            // btnARA
            // 
            this.btnARA.Location = new System.Drawing.Point(100, 153);
            this.btnARA.Name = "btnARA";
            this.btnARA.Size = new System.Drawing.Size(119, 23);
            this.btnARA.TabIndex = 2;
            this.btnARA.Text = "ARA";
            this.btnARA.UseVisualStyleBackColor = true;
            this.btnARA.Click += new System.EventHandler(this.btnARA_Click);
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBul";
            this.Load += new System.EventHandler(this.frmOgrBul_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Button btnARA;
    }
}