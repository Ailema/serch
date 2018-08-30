using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        [Key]
        public int codigo { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public decimal precio { set; get; }
        public DateTime ultimacompra { set; get; }
        public int unidades { set; get; }
    }
}