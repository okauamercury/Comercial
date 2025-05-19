using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ComercialTDSClass
{
    public class Produto
    {
     public int Id { get; set; }
     public string? CodBarras { get; set; }
     public string? Descricao { get; set; }
     public double? ValorUnit { get; set; }
     public string? UnidadeVenda { get; set; }
     public Categoria? Categoria { get; set; }
     public double? EstoqueMinimo { get; set; }
     public double? ClassDesconto { get; set; }
     public byte[]? Imagem { get; set; }
     public DateTime? DataCad { get; set; }
     public bool Descontinuado { get; set; }
        

        public Produto()
        {
            Categoria = new();
        }
        public Produto(int id, string? codBarras, string? descricao, double? valorUnit, string? unidadeVenda, Categoria? categoria, double? estoqueMinimo, double? classDesconto, byte[]? imagem, DateTime? dataCad, bool descontinuado)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClassDesconto = classDesconto;
            Imagem = imagem;
            DataCad = dataCad;
            Descontinuado = descontinuado;
        }
        public Produto(string? codBarras, string? descricao, double? valorUnit, string? unidadeVenda, Categoria? categoria, double? estoqueMinimo, double? classDesconto, byte[]? imagem)
        {
            
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClassDesconto = classDesconto;
            Imagem = imagem;
        }
        public void Inserir()
        {
            
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_inserir";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao",Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spClassDesconto", ClassDesconto);
            cmd.Parameters.AddWithValue("spimagem", Imagem);
        }
        public bool Atualizar()
        {
            return true;
        }
        public static Produto ObterPorId(int id) 
        {
            Produto produto = new();

            return produto;
        }
        public static List<Produto> ObterLista()
        {
            List<Produto> produtos = new();
            return produtos;
        }

           
    }
}

      
