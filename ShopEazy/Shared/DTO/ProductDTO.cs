using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;//using Microsoft.EntityFrameworkCore;



namespace ShopEazy.Shared.DTO
{
    
    public partial class ProductDTO
    {
      
        public string Name { get; set; } = null!;
       
        public string? Desc { get; set; }
       
        public string? Sku { get; set; }
      
        public decimal Price { get; set; }
       
        public string? Remark { get; set; }

        public string? ShortDescription { get; set; }
        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; } = 1;

        public int InventoryId { get; set; } = 1;

        //public ProductDTO(string name,string desc,string sku,decimal price,string remark)
        //{
        //    Name= name;
        //    Desc= desc;
        //    Sku= sku;
        //    Price= price;
        //    Remark = remark;

        //}

        //public ProductDTO()
        //{
        //    Name = p.Name;
        //    Desc = p.Desc;
        //    Sku = p.Sku;
        //    Price = p.Price;
        //    Remark = p.Remark;
        //    ShortDescription = "Short description";
        //}

    }
}
