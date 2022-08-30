using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("product_inventory")]
    public partial class ProductInventory
    {
        public ProductInventory()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Column("quntity")]
        [StringLength(50)]
        public string? Quntity { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [InverseProperty("Inventory")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
