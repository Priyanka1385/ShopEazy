using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
    
    public partial class OrderDetailDTO
    {
       
        public int Id { get; set; }
       
        public int UserId { get; set; }
       
        public int PaymentId { get; set; }
        
        public decimal Total { get; set; }
       
        public DateTime CreatedAt { get; set; }
      
        public DateTime? ModifiedAt { get; set; }
       
        public DateTime? DeletedAt { get; set; }
        
        public string? Remark { get; set; }

       
        public virtual PaymentDetailDTO Payment { get; set; } = null!;
       
        public virtual UserDTO User { get; set; } = null!;
       
    }
}
