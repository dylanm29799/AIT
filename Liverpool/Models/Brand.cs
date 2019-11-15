using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class Brand
    {
        private ICollection<Type> _types;

        public Brand()
        {
            _types = new List<Type>();
        }

        [Key]
        public int BrandID { get; set; }
        public string Name { get; set; }

        public string Info { get; set; } 

        public virtual ICollection<Type> Types
        {
            get { return _types; }
            set { _types = value; }
        }
    }
}