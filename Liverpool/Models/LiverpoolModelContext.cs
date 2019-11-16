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
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<Extras> Extrass { get; set; }

    }
}