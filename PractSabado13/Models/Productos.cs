using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PractSabado13.Models
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        public int id_producto { get; set; }
        public string FechaProduc { get; set; }
        public string Categoria { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}