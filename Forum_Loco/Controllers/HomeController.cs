using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
namespace Forum_Loco.Controllers
{
    public class HomeController : Controller
    {
        Models.DbLocoContext db = new Models.DbLocoContext();
        public ViewResult Landing()
        {
            return View();
        }
        public ActionResult AllItems(string id)
        {   
            return View("AllItems", db.Products.ToList());
        }
    }
}
