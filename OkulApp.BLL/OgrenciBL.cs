using System;
using System.Data.SqlClient;
using OkulApp.MODEL;
using DAL;
using System.Runtime.CompilerServices;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {

        private Helper hlp;
        public OgrenciBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };


            return hlp.ExecuteNonQuery("Insert into tblOgrenciler values(@Ad,@Soyad,@Numara)", p) > 0;

        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara),
                             new SqlParameter("@Ogrenciid",ogr.Ogrenciid)
                         };

            return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@Ogrenciid", p) > 0;
        }

        public bool OgrenciSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@OgrenciId", id) };

            return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@OgrenciId", p) > 0;
        }

        public Ogrenci OgrenciBul(string numara)
        {
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };

            var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler where Numara=@Numara", p);
            Ogrenci ogr = null;
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Numara = dr["Numara"].ToString();
            }
            dr.Close();
            return ogr;
        }
    }
}
//n Katmanlı Mimari