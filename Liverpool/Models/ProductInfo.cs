using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class ProductInfo
    {
        private ICollection<Information> _information;

        public ProductInfo()
        {
            _information = new List<Information>();
        }

        [Key]
        public int prodID { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }


  


        public virtual ICollection<Information> Informations
        {
            get { return _information; }
            set { _information = value; }
        }
    }
}