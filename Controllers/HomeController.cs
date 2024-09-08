using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshoper.Models;
namespace Eshoper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ESHOP_DBEntity DBcontext = new ESHOP_DBEntity();
        public ActionResult Index(int id)
        {
            var sp = from s in DBcontext.Products where s.CatId == id select s;
            return View(sp);    
        }
        

    }
}