using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace ComercialTDSClass
{
    public static class Banco
    {
        
        //List<object> lista = new();
        public static string StrConn { get; set; }

        public static MySql.Data.MySqlClient.MySqlCommand Abrir( string strconn ="")
        {
            MySqlCommand cmd = new();
            StrConn = strconn;
            if (StrConn == string.Empty) ;
            StrConn = $"server=10.91.47.222;database=comercialtdsdb01;user=root;password=123";
            MySqlConnection cn = new MySqlConnection(StrConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
                               
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;


        }







    }
}
