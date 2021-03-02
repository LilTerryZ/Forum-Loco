using System.Linq;
using System.Web.Mvc;
using Forum_Loco.Models;


namespace Forum_Loco.Controllers
{
    public class AccountController : Controller
    {      
        
        public ActionResult Register()
        { 
            return View();
        }

        //this just displays users
        // GET: Account
        public ActionResult Index()
        {

            using (UserContext db = new UserContext()) { 
            
            return View(db.userAcc.ToList());
            }
                
        }

 

        [HttpPost]
        public ActionResult Register(User userAccount)
        {

            if (ModelState.IsValid) {
                using (UserContext db = new UserContext())
                {
                    db.userAcc.Add(userAccount);
                    db.SaveChanges();



                }

                ModelState.Clear();
                ViewBag.Message = userAccount.UserName + " Successfully created";




            }

            return View();
        }

        public ActionResult Login()
        {


            return View();
        }


        [HttpPost]
        public ActionResult Login(User userAccount)
        {

                using (UserContext db = new UserContext())
                {

                    var usr=db.userAcc.Single(u => u.UserName == userAccount.UserName && u.Password == userAccount.Password);

                    if (usr != null)
                    {

                        Session["UserID"] = usr.UserID.ToString();
                        Session["UserName"] = usr.UserName.ToString();

                        return RedirectToAction("LoggedIn");

                    }
                    else {

                        ModelState.AddModelError("","User Name or Password is wrong");
                    }




                }



            return View();
        }


        public ActionResult LoggedIn()
        {
            if(Session ["UserId"] != null)

            {
                return View();


            }
            else
            {
                return RedirectToAction("Login");

            }
            

        }




    }
}