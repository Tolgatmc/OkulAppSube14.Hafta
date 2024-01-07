using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrBul : Form
    {
       
        frmOgrKayit frm;
        public frmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmOgrBul_Load(object sender, EventArgs e)
        {

        }

        private void btnARA_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL ogrenciBL = new OgrenciBL();
                Ogrenci ogr = ogrenciBL.OgrenciBul(txtNumara.Text.Trim());
                if (ogr != null)
                {
                    frm.txtAd.Text = ogr.Ad;
                    frm.txtSoyad.Text = ogr.Soyad;
                    frm.txtNumara.Text = ogr.Numara;
                    frm.Ogrenciid = ogr.Ogrenciid;
                    this.Close();
                    frm.btnSil.Enabled = true;
                    frm.btnGuncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}

