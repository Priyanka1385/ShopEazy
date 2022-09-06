using ShopEazy.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopEazy.Shared.Models
{
    public class ProductVariant
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; } 
        public int ProductTypeId { get; set; }

        [Column(TypeName="Decimal(18,2)")]
        public Decimal Price { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        public Decimal OriginalPrice { get; set; }
    }
}
