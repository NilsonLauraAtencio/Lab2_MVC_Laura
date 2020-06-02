using lab2_MVC_Laura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_MVC_Laura.Controllers
{
    public class PersonaController : Controller
    {
        // ClsPersona clsPersona = new ClsPersona();
        List<ClsPersona> objLista = new List<ClsPersona>();

        public ActionResult Index()
        {
            //instanciar para el objetoi 1
            ClsPersona objPersona1 = new ClsPersona();
            //  Instanciar los atributos de  la clase

            objPersona1.apellido = "Porlles Carpio";
            objPersona1.nombre = "Diego";
            objPersona1.email = "porles@upt.pe";
            objPersona1.sexo = true;
            objPersona1.edad = 22;
            objPersona1.talla = 1.60;
            //pasar el objeto a la lista
            objLista.Add(objPersona1);


            //instanciar para el objetoi 1
            ClsPersona objPersona2= new ClsPersona();
            //  Instanciar los atributos de  la clase

            objPersona2.apellido = "Mamani Ayala";
            objPersona2.nombre = "Brandon";
            objPersona2.email = "bayala@upt.pe";
            objPersona2.sexo = true;
            objPersona2.edad = 23;
            objPersona2.talla = 1.65;
            //pasar el objeto a la lista
            objLista.Add(objPersona2);

            //instanciar para el objetoi 3
            ClsPersona objPersona3 = new ClsPersona();
            //  Instanciar los atributos de  la clase

            objPersona3.apellido = "Sosa Bedoya";
            objPersona3.nombre = "Sharon";
            objPersona3.email = "sharonbed@upt.pe";
            objPersona3.sexo = false;
            objPersona3.edad = 24;
            objPersona3.talla = 1.68;
            //pasar el objeto a la lista
            objLista.Add(objPersona3);


            //instanciar para el objetoi 1
            ClsPersona objPersona4 = new ClsPersona();
            //  Instanciar los atributos de  la clase

            objPersona4.apellido = "Estrella Pàlacios";
            objPersona4.nombre = "Katherine";
            objPersona4.email = "kestrella@upt.pe";
            objPersona4.sexo = false;
            objPersona4.edad = 25;
            objPersona4.talla = 1.72;
            //pasar el objeto a la lista
            objLista.Add(objPersona4);



            return View(objLista);
        }
    }
}