using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class MonedasController : Controller
    {
        // GET: Monedas
        public ActionResult Index()
        {
            return View(new Monedas());
        }
        [HttpPost]
        public ActionResult index(Monedas monedas, string dolar12)
        {
            if(dolar12 == "123")
            {
                monedas.total = monedas.dolar * monedas.multiplicador;
            }
            else if (dolar12 =="12")
            {
                monedas.total = monedas.multiplicador / 0.017;
            }

            return View(monedas);
        }
    }
}