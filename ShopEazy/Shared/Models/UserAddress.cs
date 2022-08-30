using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.Models
{
    [Table("user_address")]
    public partial class UserAddress
    {
        [Key]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("address_line_1")]
        [StringLength(1)]
        public string AddressLine1 { get; set; } = null!;
        [Column("address_line_2")]
        [StringLength(1)]
        public string? AddressLine2 { get; set; }
        [Column("city")]
        [StringLength(30)]
        //[Unicode(false)]
        public string City { get; set; } = null!;
        [Column("state")]
        [StringLength(30)]
        //[Unicode(false)]
        public string State { get; set; } = null!;
        [Column("country")]
        [StringLength(30)]
        //[Unicode(false)]
        public string Country { get; set; } = null!;
        [Column("postalcode")]
        [StringLength(30)]
        //[Unicode(false)]
        public string Postalcode { get; set; } = null!;
        [Column("delivery_address")]
        public bool DeliveryAddress { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }
        [Column("deleted_at", TypeName = "datetime")]
        public DateTime? DeletedAt { get; set; }
        [Column("remark")]
        public string? Remark { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserAddresses")]
        public virtual User User { get; set; } = null!;
    }
}
