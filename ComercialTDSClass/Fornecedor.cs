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
        public string?Fantasia { get; set; }
        public string? Cnpj { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }


        public Fornecedor() { }
        public Fornecedor(int id, string razaosocial, string fantasia, string cnpj)
        {
            Id = id;
            RazaoSocial = razaosocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
        }
        public Fornecedor(string? razaosocial, string fantasia, string cnpj)
        {
            
            RazaoSocial = razaosocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
        }

        public Fornecedor(int id, string razaosocial, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaosocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }
        public Fornecedor(string razaosocial, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            
            RazaoSocial = razaosocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
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
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
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
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
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

                
                    
            
               
                  
                
                 
               
           
