using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("user_payment")]
    public partial class UserPayment
    {
        [Key]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("payment_type")]
        [StringLength(1)]
        ////[Unicode(false)]
        public string? PaymentType { get; set; }
        [Column("provider")]
        [StringLength(1)]
        ////[Unicode(false)]
        public string? Provider { get; set; }
        [Column("account_no")]
        public int? AccountNo { get; set; }
        [Column("expiry_date", TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserPayments")]
        public virtual User User { get; set; } = null!;
    }
}
