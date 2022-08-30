using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEasy.Shared.DTO
{
    public class APIResponse
    {
        public bool Result { get; set; }
        public string? Message { get; set; }
        public object? Response { get; set; }
    }
}
