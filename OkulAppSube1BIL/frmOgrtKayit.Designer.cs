namespace OkulAppSube1BIL
{
    partial class frmOgretmenKayit
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
            this.Ad = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.Tc = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTCkimlik = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(31, 46);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(20, 13);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(31, 87);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(37, 13);
            this.Soyad.TabIndex = 1;
            this.Soyad.Text = "Soyad";
            // 
            // Tc
            // 
            this.Tc.AutoSize = true;
            this.Tc.Location = new System.Drawing.Point(31, 138);
            this.Tc.Name = "Tc";
            this.Tc.Size = new System.Drawing.Size(20, 13);
            this.Tc.TabIndex = 2;
            this.Tc.Text = "Tc";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(125, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtTCkimlik
            // 
            this.txtTCkimlik.Location = new System.Drawing.Point(125, 138);
            this.txtTCkimlik.Name = "txtTCkimlik";
            this.txtTCkimlik.Size = new System.Drawing.Size(100, 20);
            this.txtTCkimlik.TabIndex = 5;
            
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtTCkimlik);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.Tc);
            this.groupBox1.Location = new System.Drawing.Point(199, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 248);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OgretmenKayit";
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(99, 201);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 7;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // frmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgretmenKayit";
            this.Text = "OgretmenKayit";
        
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.Label Tc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTCkimlik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Kaydet;
    }
}