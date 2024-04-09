using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__GestaoVendas.pt.com.Gvendas.CONEXAO
{
    public class Connect
    {
        public MySqlConnection GetConnection()
        {
            MySqlConnection conn;
            string connString;
            connString = "server = localhost; Port = 3307; uid = root; pwd = toor; database = BDISTEC";
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            return new MySqlConnection(connString);
        }
    }
}
