using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class Size
    {
        private ICollection<Clothing> _clothing;

        public Size()
        {
            _clothing = new List<Clothing>();
        }

        [Key]
        public int SizeID { get; set; }
        public string SizeName { get; set; }
        public string SizeChar { get; set; }
        


        public virtual ICollection<Clothing> Clothings
        {
            get { return _clothing; }
            set { _clothing = value; }
        }
    }
}