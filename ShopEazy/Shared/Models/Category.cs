using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using ShopEazy.Shared.Models;

namespace ShopEazy.Shared.Models
{
    [Table("Categories")]
    public partial class Category
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("Description")]
        public string? Description { get; set; }

        public string Url { get; set; }

        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Column("modified_at", TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }

        [Column("IsActive", TypeName = "bit")]
        public bool IsActive { get; set; }

    }
}
