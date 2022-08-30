using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
   
    public partial class UserPaymentDTO
    {
       
        public int UserId { get; set; }
        
        public string? PaymentType { get; set; }
       
        public string? Provider { get; set; }
       
        public int? AccountNo { get; set; }
       
        public DateTime? ExpiryDate { get; set; }
       
        public DateTime CreatedAt { get; set; }
       
        public DateTime? ModifiedAt { get; set; }
       
        public DateTime? DeletedAt { get; set; }
       
        public string? Remark { get; set; }

       
    }
}
