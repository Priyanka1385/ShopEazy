using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("product_discount")]
    public partial class ProductDiscount
    {
        public ProductDiscount()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Column("desc")]
        public string? Desc { get; set; }
        [Column("discount_percent", TypeName = "decimal(18, 0)")]
        public decimal DiscountPercent { get; set; }
        [Column("active")]
        public bool? Active { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [InverseProperty("Discount")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
