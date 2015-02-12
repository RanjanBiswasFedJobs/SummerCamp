using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using SummerCamp.Model;
using SummerCamp.Web.Helper;

namespace SummerCamp.Web.Controllers
{
    public class SessionsMVCController : MVCBaseController
    {
        static IServerDataRestClient RestClient = new ServerDataRestClient();

        public SessionsMVCController(IServerDataRestClient restClient)
            {
                RestClient = restClient;
        }


        public SessionsMVCController()
        {


        }


        [HttpGet]
        public ViewResult SessionDetails(int id)
        {

            ViewBag.Title = "Session Information";
            return View(RestClient.GetById(id));

        }


        public ViewResult    RegisterClass()
        {
            return View();


        }

        [HttpPost]
        public void RegisterClass(int id)
        {



        }
       
    }
}