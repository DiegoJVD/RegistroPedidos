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

        public Productos(int ProductoId, string Descripcion, decimal Costo, int Inventario){
            this.ProductoId = ProductoId;
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.Inventario = Inventario;
        }



    }
}