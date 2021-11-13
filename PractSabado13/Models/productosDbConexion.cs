using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PractSabado13.Models
{
    public class productosDbConexion : DbContext
    {
        public productosDbConexion() : base("productosDbConexion")
        {

        }
        public DbSet<Productos> producto { get; set; }
    }
}