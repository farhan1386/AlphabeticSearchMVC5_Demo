using MvcAlphabeticSearch_Demo.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcAlphabeticSearch_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerContext db = new CustomerContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCustomer()
        {
            var customer = db.Customers.ToList();
            return Json(new { data = customer }, JsonRequestBehavior.AllowGet);
        }
    }
}