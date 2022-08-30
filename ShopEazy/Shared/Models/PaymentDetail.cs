using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("payment_detail")]
    public partial class PaymentDetail
    {
        public PaymentDetail()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int Id { get; set; }
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("amount")]
        public int Amount { get; set; }
        [Column("provider")]
        [StringLength(50)]
        //[Unicode(false)]
        public string Provider { get; set; } = null!;
        [Column("status")]
        [StringLength(50)]
        //[Unicode(false)]
        public string Status { get; set; } = null!;
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [InverseProperty("Payment")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
