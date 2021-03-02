using System.Linq;
using System.Web.Mvc;
using Forum_Loco.Models;
using System.Web.Mvc.Html;
namespace Forum_Loco.Controllers
{
    public class ProductController : Controller
    {
        DbLocoContext ctx = new DbLocoContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            Product p = ctx.Products.Find(id);
            Cart c = ctx.Carts.Where(crt => crt.SessionId == HttpContext.Session.SessionID).FirstOrDefault();

            ProductViewModel pvm = new ProductViewModel();
            pvm.Product = p;

            CartItemRequest cir = new CartItemRequest();
            cir.CartId = c.Id;
            cir.ProductId = p.ProductId;
            cir.Count = 0;

            CartProduct cp = c.CartItems.Where(ci => ci.ProductId == p.ProductId).FirstOrDefault();
            if (cp != null)
            {
                cir.Count = cp.Count;
            }

            pvm.ItemRequest = cir;

            return View(pvm);
        }
    }
}