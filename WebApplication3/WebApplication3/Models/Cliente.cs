using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Cliente
    {
        [Key]
        public int id { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public DateTime compra { set; get; }

    }
}