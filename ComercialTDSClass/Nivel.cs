using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ComercialTDSClass
{
    public class Nivel
    {
        // propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        // construtor padrão
        public Nivel() { }
        
        public Nivel( string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        // inserir, atualizar, listar, ObterPorId(id)

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_insert";
            //cmd.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spnome",Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void Atualizar()
        {
            
           
        }


    }
}
