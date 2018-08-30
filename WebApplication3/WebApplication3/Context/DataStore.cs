using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class DataStore:DbContext
    {
        public DbSet<Product> Products { set; get; }
    }
}