using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        private Helper hlp;
        public OgretmenBL()
        {
            hlp = Helper.GetInstance;
        }

        public bool OgretmenEkle(Ogretmen ogrt)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad),
                             new SqlParameter("@Soyad",ogrt.Soyad),
                             new SqlParameter("@TCkimlik",ogrt.TCkimlik)
                         };

            return hlp.ExecuteNonQuery("Insert into tblogretmenler values(@Ad, @Soyad, @TCkimlik)", p) > 0;
        }
    }
}
