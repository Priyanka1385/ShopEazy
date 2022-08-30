using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("users")]
    public partial class User
    {
        public User()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ShoppingSessions = new HashSet<ShoppingSession>();
            UserAddresses = new HashSet<UserAddress>();
            UserPayments = new HashSet<UserPayment>();
        }

        [Key]
        public int Id { get; set; }
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; } = null!;
        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [Column("salt")]
        public Guid? Salt { get; set; }
        [Column("firstname")]
        [StringLength(50)]
        public string? Firstname { get; set; }
        [Column("lastname")]
        [StringLength(50)]
        public string? Lastname { get; set; }
        [Column("phoneno")]
        public int? Phoneno { get; set; }
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

        [InverseProperty("User")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ShoppingSession> ShoppingSessions { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserPayment> UserPayments { get; set; }
    }
}
