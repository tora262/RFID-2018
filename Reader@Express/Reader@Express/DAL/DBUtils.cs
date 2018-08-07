using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Reader_Express.DAL
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "tag_information";
            string username = "root";
            string password = "1969626298";

            return DBMySqlUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
