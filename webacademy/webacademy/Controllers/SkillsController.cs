using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webacademy.Models;

namespace webacademy.Controllers
{
    public class SkillsController : Controller
    {
        public ActionResult Index()
        {
            vmIndex vm = new vmIndex() 
            {
                ExtraMessage ="We are inside the Skills controller and Index action"
            };
            return View("Index", vm);
        }

    }
}
