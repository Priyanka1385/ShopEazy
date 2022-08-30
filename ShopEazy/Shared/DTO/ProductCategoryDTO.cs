using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
   
    public partial class ProductCategoryDTO
    {
       
        
        public string? Name { get; set; }
       
        public string? Desc { get; set; }
        
        public DateTime CreatedAt { get; set; }
       
        public DateTime? ModifiedAt { get; set; }
       
        public DateTime? DeletedAt { get; set; }

       
    }
}
