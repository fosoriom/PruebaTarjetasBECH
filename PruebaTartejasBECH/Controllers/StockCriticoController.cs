using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTartejasBECH.Controllers
{
    public class StockCriticoController : Controller
    {
        // GET: StockCritico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditarStockCritico()
        {
            return View();
        }
    }
}