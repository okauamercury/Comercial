using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
namespace ComercialTDSClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Cep { get; set; }
        public string? Longradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo { get; set; }
        public Endereco() { }

        public Endereco(string? cep, string? longradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo)
        {
           
            Cep = cep;
            Longradouro = longradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
         // propriedades
       
            Cidade = cidade;
            Uf = uf;
            Tipo = tipo;
        }

        public Endereco(int id, string? cep, string? longradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo)
        {
            Id = id;
            Cep = cep;
            Longradouro = longradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo = tipo;
        }


        // metodos construtores


        public static List<Endereco> ObterListaPorClienteId()
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select *from enderecos order by";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Endereco endereco = new();
                dr.GetInt32(0);
                dr.GetString(1);
                dr.GetString(2);
                dr.GetString(3);
                dr.GetString(4);
                dr.GetString(5);
                dr.GetString(6);
                dr.GetString(7);
                dr.GetString(8);
                dr.GetString(9);
            }
            dr.Close();
            cmd.Connection.Close();
            return enderecos;
           

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splongradouro", Longradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            Id = Convert.ToInt32(cmd.ExecuteScalar);

            cmd.Connection.Close();
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splongradouro", Longradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            return cmd.ExecuteNonQuery()>0 ? true: false;


        }
        public static Endereco ObterPorId(int id) 
        {
            Endereco enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Endereco endereco = new();
                dr.GetInt32(0);
                dr.GetString(1);
                dr.GetString(2);
                dr.GetString(3);
                dr.GetString(4);
                dr.GetString(5);
                dr.GetString(6);
                dr.GetString(7);
                dr.GetString(8);
                dr.GetString(9);
            }
            dr.Close();
            cmd.Connection.Close();
            return enderecos;

        }
        public static Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "sp_endereco_delete";


        }
        
        

        
        



    }




}
