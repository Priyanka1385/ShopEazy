using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
   
    public partial class UserAddressDTO
    {
        
        public int UserId { get; set; }
       
        public string AddressLine1 { get; set; } = null!;
        
        public string? AddressLine2 { get; set; }
        
        public string City { get; set; } = null!;
        
        public string State { get; set; } = null!;
       
        public string Country { get; set; } = null!;
        
        public string Postalcode { get; set; } = null!;
        
        public bool DeliveryAddress { get; set; }
       
        public DateTime CreatedAt { get; set; }
       
        public DateTime? ModifiedAt { get; set; }
     
        public DateTime? DeletedAt { get; set; }
       
        public string? Remark { get; set; }

       
        public virtual UserDTO User { get; set; } = null!;
    }
}
