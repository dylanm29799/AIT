using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Liverpool.Models
{
    public class TypeName
    {
        private ICollection<Information> _information;

        public TypeName()
        {
            _information = new List<Information>();
        }
        public int typeid { get; set; }
        public string typeName { get; set; }
        public int Sex { get; set; }
       



        public virtual ICollection<Information> Informations
        {
            get { return _information; }
            set { _information = value; }
        }
    }
}