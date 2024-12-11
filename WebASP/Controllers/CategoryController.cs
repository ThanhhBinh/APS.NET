using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebASP.Context;

namespace WebASP.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        WebAPSEntities objASPNETEntities = new WebAPSEntities();

        public ActionResult AllCategory()
        {
            var lstAllCategory = objASPNETEntities.Categories.ToList();
            return View(lstAllCategory);
        }

        public ActionResult ProductByCategory()
        {
            return View();
        }
    }
}