using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Loga ()
        {
            string username = Request["username"];
            string login = Request["login"];

            if((login == "abc")&&(username=="tiago"))
            {
                
                ViewBag.log = "LOGADO!!!!";

            }
            else
            {
                ViewBag.log = "SENHA INCORETA!!!";
            }
            return View();
        }
    }
}