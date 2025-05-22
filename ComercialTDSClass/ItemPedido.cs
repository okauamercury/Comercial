using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class ItemPedido
    {

        public int Id { get; set; }
        public int PedidoID { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
       public ItemPedido()
       {
            Produto = new(); 
       }
        public ItemPedido(int id, int pedidoID, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoID = pedidoID;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int pedidoID, Produto produto, double quantidade, double desconto)
        {
            PedidoID = pedidoID;
            Produto = produto;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int id, double quantidade, double desconto)
        {
            Id = id;
            Quantidade = quantidade;
            Desconto = desconto;
        }

           
        // metodo da classe
        public void Deletar(int id)
        {

        }

        public void Inserir()
        {
           
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedidoid",PedidoID);
            cmd.Parameters.AddWithValue("spproduto",Produto);
            cmd.Parameters.AddWithValue("spquantidade",Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            
            cmd.Connection.Clone();
        }
    }
}