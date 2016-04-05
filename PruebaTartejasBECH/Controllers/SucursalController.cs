using PruebaTartejasBECH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTartejasBECH.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AgregarSucursal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarSucursal(Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {

            }
            return View(sucursal);
        }
    }
}