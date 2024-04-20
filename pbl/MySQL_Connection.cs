using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace pbl
{
    public class MySQL_Connection
    {
        
        public MySqlConnection getConnection(string db_name)
        {
            string constr = "server = localhost; user = root; pwd = 010104; database =" + db_name +"; port = 3306";
            MySqlConnection con = new MySqlConnection(constr);
            return con;
        }
    }
}
