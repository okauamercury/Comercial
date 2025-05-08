using MySql.Data.MySqlClient;
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
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strconn = // colocar as informações da conexão



                MySqlConnection cn = new(strconn);
               try
               {
                cn.Open();
               }
        }
    }
}
