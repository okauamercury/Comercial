using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata.Ecma335;

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

            cmd.Connection.Close();
        }
        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select *from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
                //nivel = new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));

            }
            dr.Close();
            cmd.Connection.Close();
            return nivel;
        }
        public static List<Nivel> ObterLista()
        {
            List<Nivel> niveis = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select *from niveis order by nome;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new Nivel
                    (dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    
                    )
                );
               
            }
            return niveis;





        }

    }
}


        

