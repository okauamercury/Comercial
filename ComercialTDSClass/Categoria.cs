using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        // construtor padrão
        public Categoria() { }

        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        // inserir, atualizar, listar, ObterPorId(id)
        /// <summary>
        /// Método para inserir um novo nível no banco de dados.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            //cmd.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }
        public static Categoria ObterPorId(int id)
        {
            Categoria nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select *from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
                //nivel = new Categoria(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));

            }
            dr.Close();
            cmd.Connection.Close();
            return nivel;
            cmd.Connection.Close();
        }
        public static List<Categoria> ObterLista()
        {
            List<Categoria> categorias = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select *from categorias order by nome;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorias.Add(new Categoria
                    (dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)

                    )
                );

            }
            return categorias;
            cmd.Connection.Close();




        }
        public bool Atualizar()
        {
            /// 
            ///como esse metodo não é estatico, precisamos considerar que as propriedades
            ///já possuem valores atribuidos
            ///

            bool Atualizado = false;
            if (Id < 1) return Atualizado;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            if (cmd.ExecuteNonQuery() > 0)
            {

                Atualizado = true;

            }
            cmd.Connection.Close();
            return Atualizado;
        }
         
    }   
}
