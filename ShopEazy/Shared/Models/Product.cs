using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("Product")]
    public partial class Product    {
       

        [Key]
        public int Id { get; set; }


        [Column("Title")]
        [StringLength(50)]
        public string Title { get; set; } = null!;

        [Column("Description")]
        public string? Description { get; set; }

        [Column("SKU")]
        [StringLength(50)]
        
        public string? SKU { get; set; }

        [Column("Price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }

        public byte IsActive { get; set; } = 1;
        public string? Remark { get; set; }

      
    }
}
