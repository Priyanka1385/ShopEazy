using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("order_details")]
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("payment_id")]
        public int PaymentId { get; set; }
        [Column("total", TypeName = "decimal(18, 0)")]
        public decimal Total { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [ForeignKey("PaymentId")]
        [InverseProperty("OrderDetails")]
        public virtual PaymentDetail Payment { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("OrderDetails")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Order")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
