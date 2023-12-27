using Loginnn.Models;
using System.Linq;
using System.Web.Mvc;

namespace Loginnn.Controllers
{
    public class LoginnController : Controller
    {
        private UsDBContext db = new UsDBContext();
        // GET: Loginn
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User user)
        {
            if(ModelState.IsValid)
            {
                return View(user);
            }
            return RedirectToAction("Index", "Loginn");
        }
        public ActionResult Logout()
        {
            return View();
        }

        public ActionResult GetUser()
        {
            return View(db.Users.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,username,password")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("GetUser");
            }
            return View(user);
        }
    }
}