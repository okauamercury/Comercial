using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var item = ItemPedido.ObterPorId(id);
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update estoques set " +
                $"quantidade = quantidade + {item.Quantidade} " +
                $"\n where produto_id = {item.Produto.Id};";
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = $"delete from itempedido where id = {id}";
                cmd.ExecuteNonQuery();
            }
            cmd.Connection.Close();
        }

        public void Inserir()
        {
           
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", PedidoID);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade",Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            
            cmd.Connection.Clone();
        }
        public bool Atualizar()
        {
            
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_update";
            cmd.Parameters.AddWithValue("sppedidoid", PedidoID);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            bool atualizado = cmd.ExecuteNonQuery() > 0 ? true : false;
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
           
            return atualizado;
        }
        public static ItemPedido ObterPorId(int id)// id do item do pedido
        {
            ItemPedido itempedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select *from itempedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itempedido = new(
                  dr.GetInt32(0),
                  dr.GetInt32(1),
                  Produto.ObterPorId(dr.GetInt32(2)),
                  dr.GetDouble(3),
                  dr.GetDouble(4),
                  dr.GetDouble(5)
                );
               
            }
            dr.Close();
            cmd.Connection.Close();
            return itempedido;
        }
        public static List<ItemPedido> ObterListaPorPedidoId(int pedidoId)
        {

            List<ItemPedido> Items = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select *from itempedido where pedido_id = {pedidoId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Items.Add(new(
                         dr.GetInt32(0),
                         dr.GetInt32(1),
                         Produto.ObterPorId(dr.GetInt32(2)),
                         dr.GetDouble(3),
                         dr.GetDouble(4),
                         dr.GetDouble(5)
                  )
                );

            }
            dr.Close();
            cmd.Connection.Close();
            return Items;
        }                                                  

    }
}