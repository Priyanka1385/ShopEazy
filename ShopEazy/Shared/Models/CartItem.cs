using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("cart_item")]
    public partial class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Column("session_id")]
        public int SessionId { get; set; }
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

        [ForeignKey("ProductId")]
        [InverseProperty("CartItems")]
        public virtual Product Product { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("CartItems")]
        public virtual ShoppingSession Session { get; set; } = null!;
    }
}
