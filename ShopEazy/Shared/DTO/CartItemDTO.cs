using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
   
    public partial class CartItemDTO
    {

        public int SessionId { get; set; }
        
        public int ProductId { get; set; }
      
        public int Quentity { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime? ModifiedAt { get; set; }
       
        public string? Remark { get; set; }

       
    }
}
