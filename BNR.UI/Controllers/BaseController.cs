using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BNR.UI.Controllers
{
    public class BaseController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //ADD ALL HTTP ERROR HANDLING HUR

        public ActionResult PageNotFound()
        {
            return View();
        }

        //AccessDenied

        //Error
    }
}