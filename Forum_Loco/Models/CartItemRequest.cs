using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum_Loco.Models
{
    public class CartItemRequest
    {
        public int ProductId { get; set; }

        public int CartId { get; set; }

        public int Count { get; set; }
    }
}