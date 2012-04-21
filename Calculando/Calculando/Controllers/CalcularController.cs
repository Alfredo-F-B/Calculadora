using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculando.Models;

namespace Calculando.Controllers
{
    public class CalcularController : Controller
    {
        //
        // GET: /Calcular/

        public ActionResult Sumar(Calcular datos)
        {
            ViewBag.r = datos.num1 + datos.num2;
            return this.View();
        }
        public ActionResult Restar(Calcular datos)
        {
            ViewBag.r = datos.num1 - datos.num2;
            return this.View();
        }
        public ActionResult Multiplicar(Calcular datos)
        {
            ViewBag.r = datos.num1 * datos.num2;
            return this.View();
        }
        public ActionResult Dividir(Div datos)
        {
            ViewBag.r = datos.num1 / datos.num2;
            return this.View();
        }


    }
}
