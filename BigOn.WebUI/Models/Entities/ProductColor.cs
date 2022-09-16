using BigOn.WebUI.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.WebUI.Models.Entities
{
    public class ProductColor : BaseEntity
    {
        public string  Name { get; set; }
        public ICollection<Product> Colors { get; set; }
    }
}
