using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OkulOtomasyonu
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti() {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-SDOIRU1;Initial Catalog=dba_OkulOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
