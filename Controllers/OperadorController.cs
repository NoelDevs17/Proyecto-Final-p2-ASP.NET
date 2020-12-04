using Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Final.Controllers
{
    public class OperadorController : Controller
    {
        // GET: Operador
        public ActionResult Index()
        {
            return View(new Operador());
        }

        [HttpPost]
        public ActionResult Index(Operador op, string calculadora)
        {
            if (calculadora == "add")
            {
                op.resultado = op.valor1 + op.valor2;

            }
            else if (calculadora == "min")
            {
                op.resultado = op.valor1 - op.valor2;
            }
            else if (calculadora == "sub")
            {
                op.resultado = op.valor1 * op.valor2;
            }
            else if (calculadora == "divv")
            {
                op.resultado = op.valor1 / op.valor2;
            }

            return View(op);
        }
    }
}