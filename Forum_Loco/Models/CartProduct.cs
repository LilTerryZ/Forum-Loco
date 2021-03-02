using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum_Loco.Models
{
    public class CartProduct
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Cart")]
        public int CartId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Products")]
        public int ProductId { get; set; }

        [Required]
        public int Count { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual Product Products { get; set; }
    }
}