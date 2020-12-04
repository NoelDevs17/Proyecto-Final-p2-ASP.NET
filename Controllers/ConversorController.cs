using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class ConversorController : Controller
    {
        // GET: Conversor
        public ActionResult Index()
        {
            return View(new Conversor());
        }

        [HttpPost]
        public ActionResult index(Conversor con, string conversor11)
        {
            if (conversor11 == "fahrenheit")
            {
                con.resultado = (con.grados - 32) * 5 / 9;
            }
            else if (conversor11 == "Celsius")
            {
                con.resultado = (con.grados * 9 / 5) + 32;
            }
            return View(con);
        }
    }
}