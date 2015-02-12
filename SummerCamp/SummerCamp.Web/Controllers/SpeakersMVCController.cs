using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerCamp.Data.Contracts;
using SummerCamp.Model;

namespace SummerCamp.Web.Controllers
{
    public class SpeakersMVCController : MVCBaseController
    {
        // GET: SpeakersMVC
        public ActionResult Index()
        {
            return View();
        }

    

    }
}