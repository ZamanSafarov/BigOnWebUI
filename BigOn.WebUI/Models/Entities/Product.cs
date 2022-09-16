using BigOn.WebUI.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.WebUI.Models.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }


        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int ProductColorId { get; set; }
        public virtual ProductColor ProductColor { get; set; }

        public int ProductSizeId { get; set; }
        public virtual ProductSize ProductSize { get; set; }

        public int ProductMaterialId { get; set; }
        public virtual ProductMaterial ProductMaterial { get; set; }

        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
