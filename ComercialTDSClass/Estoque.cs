using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Estoque
    {
        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        public Timestamp? DataUltimo { get; set; }


        public Estoque() { }
        public Estoque(decimal quantidade, Timestamp? dataUltimo)
        {
           
            Quantidade = quantidade;
            DataUltimo = dataUltimo;
        }

        public Estoque(int id, decimal quantidade, Timestamp? dataUltimo)
        {
            Id = id;
            Quantidade = quantidade;
            DataUltimo = dataUltimo;
        }
        public void Atualizar()
        {
           
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spquantidade",Quantidade);
            cmd.Parameters.AddWithValue("spdataultimo",DataUltimo);
            Id = Convert.ToInt32(cmd.ExecuteNonQuery());
            
            cmd.Connection.Close();
                     

        }
       
    }
}
