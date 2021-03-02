using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum_Loco.Models;
using System.Web.Mvc.Html;
namespace Forum_Loco.Controllers
{
    public class CartController : Controller
    {
        DbLocoContext ctx = new DbLocoContext();

        // GET: Cart
        public ActionResult Index()
        {
            Cart cart = ctx.Carts.Where(c => c.SessionId == HttpContext.Session.SessionID).FirstOrDefault();
            return View(cart);
        }

        // public void AddItems(ProductViewModel value)
        public ActionResult AddItems(ProductViewModel pvm)
        {
            CartItemRequest cir = pvm.ItemRequest;
            
            Cart c = ctx.Carts.Where(crt => crt.SessionId == HttpContext.Session.SessionID).FirstOrDefault();
            CartProduct curr = c.CartItems.Where(ci => ci.CartId == cir.CartId && ci.ProductId == cir.ProductId).FirstOrDefault();
            if (curr != null)
            {
                curr.Count = cir.Count;
            } else
            {
                CartProduct cp = new CartProduct();
                cp.ProductId = cir.ProductId;
                cp.CartId = cir.CartId;
                cp.Count = cir.Count;

                c.CartItems.Add(cp);
            }
            ctx.SaveChanges();
            return RedirectToAction("Index");
            //return View("Index", c);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Cart c = ctx.Carts.Where(crt => crt.SessionId == HttpContext.Session.SessionID).FirstOrDefault();
            c.CartItems = c.CartItems.Where(ci => ci.ProductId != id).ToList();
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
