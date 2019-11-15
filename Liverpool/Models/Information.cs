using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class Information
    {
        private ICollection<ProductInfo> _prodinfo;

        public Information()
        {
            _prodinfo = new List<ProductInfo>();
        }

        [Key]
        public int IID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        


        public virtual ICollection<ProductInfo> ProductInfos
        {
            get { return _prodinfo; }
            set { _prodinfo = value; }
        }
    }
}