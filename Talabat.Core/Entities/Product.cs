using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureURL { get; set; }
        //[ForeignKey("ProductBrand")] We Use fluent api 
        public int ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; } // Navigation Property [1->M]

       //[ForeignKey("ProductType")] We Use fluent api 
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; } // Navigation Property [1->M]

    }
}
