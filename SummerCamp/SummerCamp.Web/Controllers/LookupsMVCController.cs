using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerCamp.Data.Contracts;

namespace SummerCamp.Web.Controllers
{
    public class LookupsMVCController : MVCBaseController
    {

        public LookupsMVCController(ISummerCampUow uow)
        {
            Uow = uow;
        }
        // GET: LookupsMVC
        public ActionResult Index()
        {
            return View();
        }
    }
}