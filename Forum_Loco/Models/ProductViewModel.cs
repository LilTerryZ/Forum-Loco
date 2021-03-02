using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum_Loco.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public CartItemRequest ItemRequest { get; set; }
    }
}