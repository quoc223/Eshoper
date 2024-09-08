using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshoper.Controllers
{
    public class Erro404Controller : Controller
    {
        // GET: Erro404
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult err404()
        {
            return View();
        }
    }
}