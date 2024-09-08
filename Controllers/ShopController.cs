using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshoper.Models;
namespace Eshoper.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        ESHOP_DBEntity DBcontext = new ESHOP_DBEntity();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {

            ESHOP_DBEntity DBcontext = new ESHOP_DBEntity();
            List<Product_Category> Listpr = DBcontext.Product_Category.ToList();
            return View(Listpr);
        }

        public ActionResult ProductsDetail(int id)
        {

            List<Product_Category> Listpr1 = DBcontext.Product_Category.ToList();
            return View(Listpr1);
        }
        public ActionResult _partialLoaisanpham()
        {
            ESHOP_DBEntity DBcontext = new ESHOP_DBEntity();
            List<Category> loaisp = DBcontext.Categories.ToList();
            return PartialView(loaisp);
        }
       
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}