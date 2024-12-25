using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebASP.Context;

namespace WebASP.Controllers
{
    public class ProductController : Controller
    {
        WebAPSEntities4 objASPNETEntities = new WebAPSEntities4();

        // GET: Product
        public ActionResult AllProduct()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var objProduct = objASPNETEntities.Products.Where(n => n.id == id).FirstOrDefault();
            return View(objProduct);
        }
    }
}