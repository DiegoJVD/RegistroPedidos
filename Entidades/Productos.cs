using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId {get; set;}
        public String Descripcion {get; set;}
        public decimal Costo { get; set; }
        public int Inventario { get; set; }



    }
}