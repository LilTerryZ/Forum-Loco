using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum_Loco.Models
{
    public class Product
    {
        [Required]
        [Display(Name = "ProductCode")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public string BrandName { get; set; }
        [Required]
        [Display(Name = "Cost")]
        public double Price { get; set; }

        // public virtual ICollection<Cart> Carts { get; set; }
        //public virtual ICollection<Order> Orders { get; set; }
    }
}
