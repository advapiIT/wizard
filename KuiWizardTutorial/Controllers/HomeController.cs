using KuiWizardTutorial.Models;
using System.Web.Mvc;

namespace KuiWizardTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterViewModel model)
        {
            return View(model);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult IsEmailJustPresent(string email)
        {
            var res = email == "paolo.ponzano@gmail.com";

            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ValidateEmailStep2(string email, string name, string lastname)
        {
            var res = email.Contains(name) && email.Contains(lastname);

            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}