using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace ShopEasy.Shared.DTO
{
    [Table("users")]
    public partial class UserDTO
    {
       
        public string Username { get; set; } = null!;
       
        public string Password { get; set; } = null!;
        
        public Guid? Salt { get; set; }
        
        public string? Firstname { get; set; }
       
        public string? Lastname { get; set; }
       
        public int? Phoneno { get; set; }
       
        public bool? Active { get; set; }
       
        public DateTime CreatedAt { get; set; }
       
        public DateTime? ModifiedAt { get; set; }
       
        public DateTime? DeletedAt { get; set; }
       
        public string? Remark { get; set; }

       
    }
}
