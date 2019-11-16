using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class Clothing
    {
        private ICollection<Size> _size;

        public Clothing()
        {
            _size = new List<Size>();
        }

        [Key]
        public int ClothingID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Sex { get; set; }






        public virtual ICollection<Size> Sizes
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}