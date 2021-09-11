using LTW_GIUAKI_NHOM4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW_GIUAKI_NHOM4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult dangki(SVModel model)
        {
            return View();
        }
        public ActionResult signup(SVModel model)
        {
            return View();
        }
        public ActionResult cart()
        {
           

            return View();
        }

        public ActionResult produc()
        {
            

            return View();
        }
        public ActionResult producdetail()
        {


            return View();
        }
    }
}