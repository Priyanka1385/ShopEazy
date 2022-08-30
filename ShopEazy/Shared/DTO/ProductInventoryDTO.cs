using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
  
    public partial class ProductInventoryDTO
    {
       
        [StringLength(50)]
        public string? Quntity { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime? ModifiedAt { get; set; }
      
        public DateTime? DeletedAt { get; set; }
        
        public string? Remark { get; set; }

    }
}
