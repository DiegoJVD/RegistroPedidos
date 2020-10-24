using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class OrdenesDetalle
    {
        [Key]
        public int Id {get; set;}
        public int OrdenId { get; set; }
        public int Cantidad {get; set;}
        public Decimal Costo { get; set; }

        public int ProductoId { get; set; }

         public OrdenesDetalle(int ordenId, int productoId, int cantidad, decimal costo)
        {
            Id = 0;
            OrdenId = ordenId;
            ProductoId = productoId;
            Cantidad = cantidad;
            Costo = costo;
        }

        
    



    }
}