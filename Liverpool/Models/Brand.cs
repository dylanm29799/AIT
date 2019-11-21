using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class Brand
    {
        private ICollection<Clothing> _clothing;

        public Brand()
        {
            _clothing = new List<Clothing>();
        }

        [Key]
        public int BrandID { get; set; }
        public string Name { get; set; }

        public string Info { get; set; } 
        public string Image { get; set; }

        public virtual ICollection<Clothing> Clothings
        {
            get { return _clothing; }
            set { _clothing = value; }
        }
    }
}