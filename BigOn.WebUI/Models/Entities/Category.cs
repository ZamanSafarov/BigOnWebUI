using BigOn.WebUI.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.WebUI.Models.Entities
{

    public class Category :BaseEntity
    {
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }

        //bir chox childi ola biler deye ICollection istifade edirik
        public virtual ICollection<Category> Children { get; set; }
        public string Name { get; set; }
    }
}
