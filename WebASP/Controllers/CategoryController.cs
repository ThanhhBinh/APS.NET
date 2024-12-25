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
        WebAPSEntities4 objASPNETEntities = new WebAPSEntities4();

        public ActionResult AllCategory()
        {
            var lstAllCategory = objASPNETEntities.Categories.ToList();
            return View(lstAllCategory);
        }

        public ActionResult ProductByCategory(int id)
        {
            var listProduct = objASPNETEntities.Products.Where(n => n.category_id == id).ToList();
            return View(listProduct);
        }
    }
}