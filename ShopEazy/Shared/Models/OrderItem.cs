using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("order_item")]
    public partial class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("quentity")]
        public int Quentity { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderItems")]
        public virtual OrderDetail Order { get; set; } = null!;
        [ForeignKey("ProductId")]
        [InverseProperty("OrderItems")]
        public virtual Product Product { get; set; } = null!;
    }
}
