using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Products.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        Context ctx=new Context();
        public ActionResult ProductsTable()
        {
            
            return View(ctx.Products);

        }

        public ActionResult LinkPage(string id)
        {

            return Redirect(ctx.Products.Where(v => v.Name == id).First().Link);

        }

    }
}