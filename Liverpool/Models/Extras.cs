using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class Extras
    {
        private ICollection<Clothing> _clothing;

        public Extras()
        {
            _clothing = new List<Clothing>();
        }

        [Key]
        public int ExtraID { get; set; }
        public string ExtraName { get; set; }
        public int ExtraPrice { get; set; }
       



        public virtual ICollection<Clothing> Clothings

        {
            get { return _clothing; }
            set { _clothing = value; }
        }
    }
}