using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        
        DB d = new DB();    

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetCandidatos(int id)
        {
            //var subtemas = db.SUBTEMAS.Where(x => x.TEMA_id == id);
            //DB d = new DB();
            var subtemas = d.BuscarCandidatosPorDistrito(id);
            //var subtemas = d.BuscarTest(id);
            return Json(subtemas, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDistrito(string id)
        {
            //var subtemas = db.SUBTEMAS.Where(x => x.TEMA_id == id);
            //DB d = new DB();
            var subtemas = d.BuscarDistrito(id);
            //var subtemas = d.BuscarTest(id);
            return Json(subtemas, JsonRequestBehavior.AllowGet);
        }
    }
}