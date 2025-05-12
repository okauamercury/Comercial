using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Cliente
    {
     public List<Endereco>? Enderecos { get; set; }
     public int Id { get; set; }
     public string? Nome { get; set; }
     public string? Cpf { get; set; }
     public string? Telefone { get; set; }
     public string? Email { get; set; }
     public DateOnly Data_Nasci { get; set; }
     public Timestamp? Data_cadastro { get; set; }
     public bool? Ativo { get; set; }
        
        public Cliente() { }
        public Cliente(List<Endereco>? enderecos, int id, string? nome, string? cpf, string? telefone, string? email, DateOnly data_Nasci, Timestamp? data_cadastro, bool? ativo)
        {
            Enderecos = enderecos;
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasci = data_Nasci;
            Data_cadastro = data_cadastro;
            Ativo = ativo;
        }
        public Cliente(List<Endereco>? enderecos, string? nome, string? cpf, string? telefone, string? email, DateOnly data_Nasci, Timestamp? data_cadastro, bool? ativo)
        {
           
            Enderecos = enderecos;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_Nasci = data_Nasci;
            Data_cadastro = data_cadastro;
            Ativo = ativo;
        }



    }
}
