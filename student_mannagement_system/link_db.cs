using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace student_mannagement_system
{
    class link_db
    {
        static public MySqlConnection Connection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnectionSQLString"].ToString();
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }
        static public MySqlCommand execute(string sql, MySqlConnection conn)
        {
            MySqlCommand com = new MySqlCommand(sql, conn);
            return com;
        }
        static public void disconnection(MySqlConnection conn)
        {
            conn.Dispose();
            conn.Close();
        }
    }
}
