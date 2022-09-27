using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FacturacionProductos.Models
{
    public class Productos
    {
        [Key]
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string fecha  { get; set; }

    }

    public class FacturacionDbContext : ApplicationDbContext
    {   
        public DbSet<Productos> Producto { get; set; }


    }
    




}