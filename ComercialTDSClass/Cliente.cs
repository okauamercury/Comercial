using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace ComercialTDSClass
{
    public class Cliente
    {
     public int Id { get; set; }
     public string? Nome { get; set; }
     public string? Cpf { get; set; }
     public string? Telefone { get; set; }
     public string? Email { get; set; }
     public DateTime Data_Nasci { get; set; }
     public DateTime Data_cadastro { get; set; }
     public bool? Ativo { get; set; }
     public List<Endereco>? Enderecos { get; set; }
        
        public Cliente() { }
        public Cliente( int id, string? nome, string? cpf, string? telefone, string? email, DateTime data_Nasci, DateTime data_cadastro, bool? ativo, List<Endereco> enderecos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasci = data_Nasci;
            Data_cadastro = data_cadastro;
            Ativo = ativo;
            Enderecos = enderecos;
          
        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime data_Nasci, DateTime data_cadastro, bool? ativo)
        {

            Id = Id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasci = data_Nasci;
            Data_cadastro = data_cadastro;
            Ativo = ativo;
        }
        public void Insert()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_Nasci);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();

        }
        public bool Atualizar() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
           
            return cmd.ExecuteNonQuery()>0? true:false;
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                cliente = new
               (
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7),
                    Endereco.ObterListaPorClienteId(dr.GetInt32(0))
               ); 
                    
            }
            dr.Close();
            cmd.Connection.Close();
            return cliente;
        }
        public static List<Cliente> ObterLista()
        {
            List<Cliente> clientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetDateTime(5),
                            dr.GetDateTime(6),
                            dr.GetBoolean(7)
                  )
                ); 
            }
            dr.Close();
            cmd.Connection.Close();
            return clientes;
              


        }
       





    }
}
