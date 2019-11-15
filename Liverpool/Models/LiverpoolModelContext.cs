using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Liverpool.Models
{
    public class LiverpoolContext : DbContext
    {

        public LiverpoolContext() : base("LiverpoolModelContext")
        {


        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<ProductInfo> ProdInfo { get; set; }
        public DbSet<Type> Types { get; set; }

    }
}