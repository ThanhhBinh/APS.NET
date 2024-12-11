using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebASP.Context;
using WebASP.Models;

namespace WebASP.Controllers
{
    public class HomeController : Controller
    {
        WebAPSEntities objASPNETEntities = new WebAPSEntities();

        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();

            objHomeModel.ListProduct = objASPNETEntities.Products.ToList();
            objHomeModel.ListCategory = objASPNETEntities.Categories.ToList();

            return View(objHomeModel);
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