using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace takvimUygulaması
{
    class baglanti
    {

        public SqlConnection conn = new SqlConnection("Data Source=DENIZKAVAK\\SQLEXPRESS;Initial Catalog=takvim;Integrated Security=True");
    }
}
