using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Empleado
    {
        [Key]
        public int codigo { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public decimal salario { set; get; }
        public DateTime fechaAlta { set; get; }
        public string rango { set; get; }
    }
}