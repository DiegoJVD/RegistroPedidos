using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class Suplidores
    {
        [Key]
        public int SuplidorId {get; set;}
        public String Nombres {get; set;}

        [ForeignKey("SuplidorId")]
        public virtual List<Ordenes> Prestamos { get; set; }

    }
}