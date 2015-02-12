using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SummerCamp.Web.Controllers
{
    public class AccountMVCController : Controller
    {
        // GET: AccountMVC
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {

            return View();

        }
    }
}