using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Connection
    {

        public SqlConnection CreateAndOpenConnection()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=LAPTOP-VL67TSLU\SQLEXPRESS01;Initial Catalog=Restaurant;Integrated Security=True");
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            return conn;
        }
    }
}