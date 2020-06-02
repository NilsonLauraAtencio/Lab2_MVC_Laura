using lab2_MVC_Laura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_MVC_Laura.Controllers
{
    public class BilleteController : Controller
    {
        // GET: Billete
        public ActionResult Index()
        {
            return View();
        }
        // PRUEBA PARA LA MODIFICACION EN GITHUB
        // PRUEBA PARA LA MODIFICACION EN GITHUB
        // PRUEBA PARA LA MODIFICACION EN GITHUB
        // PRUEBA PARA LA MODIFICACION EN GITHUB
        // PRUEBA PARA LA MODIFICACION EN GITHUB
        // PRUEBA PARA LA MODIFICACION EN GITHUB
        // PRUEBA PARA LA MODIFICACION EN GITHUB

        public ActionResult Visualizar(ClsBillete objBillete)
        {
            int cantidad;
            cantidad = objBillete.monto;
            int cant100, cant50, cant20, cant10;
            int rest100, res50, res20, res10;

            cant100 = cantidad / 100;
            rest100 = cantidad % 100;

            cant50 = rest100 / 50;
            res50 = rest100 % 50;


            cant20 = res50 / 20;
            res20 = res50 % 20;


            cant10 = res20 / 10;
            res10 = res20 % 10;

            objBillete.b100 = cant100;
            objBillete.b50 = cant50;
            objBillete.b20 = cant20;
            objBillete.b10 = cant10;


            return View(objBillete);
        }
    }
}