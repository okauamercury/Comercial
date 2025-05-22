using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public string? CNPJ { get; set; }
        public int Contato { get; set; }
        public int Telefone { get; set; }
        public string? Email { get; set; }


        public Fornecedor() { }
        public Fornecedor(int id, string? razaoSocial, string? fantasia, string CNPJ)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = CNPJ;
        }
        public Fornecedor(string? razaoSocial, string? fantasia, string CNPJ)
        {
            
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = CNPJ;
        }

        public Fornecedor(int id, string? razaoSocial, string? fantasia, string CNPJ, int contato, int telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = CNPJ;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_insert";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("sprazaosocial",RazaoSocial);
            cmd.Parameters.AddWithValue("spcnpj", CNPJ);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            cmd.Connection.Close();

        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sprazaosocial", RazaoSocial);
            cmd.Parameters.AddWithValue("spcnpj", CNPJ);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            cmd.Connection.Close();

        }
        public static Fornecedor ObterPorId(int id)
        {

            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fornecedor = new();
                dr.GetInt32(0);
                dr.GetString(1);
                dr.GetString(2);
                dr.GetString(3);
                Fornecedor.ObterPorId(dr.GetInt32(4));
                dr.GetBoolean(5);
                 
            }
            dr.Close();
            cmd.Connection.Close();
            return fornecedor;
           
           

           
        }
        public static List<Fornecedor> ObterPorLista(int limit)
        {
            List<Fornecedor> fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select *from fornecedores order by";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fornecedor = new();
                dr.GetInt32(0);
                dr.GetString(1);
                dr.GetString(2);
                dr.GetString(3);
                Fornecedor.ObterPorLista(dr.GetInt32(4));
                dr.GetBoolean(5);

            }
            dr.Close();
            cmd.Connection.Close();

            return fornecedor;
        }

           
        
                 
                
                    
              
      
          

    }
}

                
                    
            
               
                  
                
                 
               
           
