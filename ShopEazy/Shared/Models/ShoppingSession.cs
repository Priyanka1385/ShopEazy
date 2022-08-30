using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("shopping_session")]
    public partial class ShoppingSession
    {
        public ShoppingSession()
        {
            CartItems = new HashSet<CartItem>();
        }

        [Key]
        public int Id { get; set; }
        [Column("userid")]
        public int Userid { get; set; }
        [Column("total")]
        public int Total { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [ForeignKey("Userid")]
        [InverseProperty("ShoppingSessions")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Session")]
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
