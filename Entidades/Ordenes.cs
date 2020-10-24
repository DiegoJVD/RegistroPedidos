using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class Ordenes
    {
        [Key]
        public int OrdenId {get; set;}
        public DateTime Fecha {get; set;}
        public int SuplidorId { get; set; }
        public int Inventario { get; set; }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalle> Detalle { get; set; }

        

        



    }
}