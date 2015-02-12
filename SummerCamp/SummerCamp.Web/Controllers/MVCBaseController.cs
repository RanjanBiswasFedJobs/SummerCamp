using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerCamp.Data.Contracts;

namespace SummerCamp.Web.Controllers
{
    public class MVCBaseController : Controller
    {
        protected ISummerCampUow Uow { get; set; }
    }
}