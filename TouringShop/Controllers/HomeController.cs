using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TouringShop.Models;
namespace TouringShop.Controllers
{
    public class HomeController : Controller
    {
        ChoBaoHo1Entities db = new ChoBaoHo1Entities();
        public ActionResult Index()
        {
            List<SanPham> sp = db.SanPhams.ToList();
            return View(sp);
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
    }
}