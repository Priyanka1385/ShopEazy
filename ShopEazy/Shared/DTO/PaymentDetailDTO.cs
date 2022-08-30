using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
    [Table("payment_detail")]
    public partial class PaymentDetailDTO
    {
       

       
        public int OrderId { get; set; }
        
        public int Amount { get; set; }
       
        public string Provider { get; set; } = null!;
        
        public string Status { get; set; } = null!;
      
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        
        public DateTime? DeletedAt { get; set; }
       
        public string? Remark { get; set; }

       
    }
}
