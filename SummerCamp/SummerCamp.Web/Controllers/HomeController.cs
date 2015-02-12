using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeCamper.Web.Controllers;
using SummerCamp.Data.Contracts;
using SummerCamp.Model;
using SummerCamp.Web.Helper;

namespace SummerCamp.Web.Controllers
{
    public class HomeController : MVCBaseController
    {
        static IServerDataRestClient RestClient = new ServerDataRestClient();

        public HomeController(IServerDataRestClient restClient)
        {
            RestClient = restClient;
        }
           
        public HomeController()
        {


        }
        
        public ActionResult Index()
        {
            ViewBag.Title = "Summer Camp Sessions";
           return View(RestClient.GetAll());
        }
    }
}
