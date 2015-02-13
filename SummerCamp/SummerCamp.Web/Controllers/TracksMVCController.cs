using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerCamp.Web.Helper;

namespace SummerCamp.Web.Controllers
{
    public class TracksMVCController : Controller
    {


         static ITracksRestClient RestClient = new TracksRestClient();

         public TracksMVCController(ITracksRestClient restClient)
            {
                RestClient = restClient;
        }


        public TracksMVCController()
        {


        }

        [HttpGet]
        // GET: TracksMVC
        public ActionResult Index()
        {
            ViewBag.Title = "Track Information";
            return View(RestClient.GetAll());
        }

        [HttpGet]

        public ActionResult TrackDetails(int id)
        {
            ViewBag.Title = "Track Details";
            return View(RestClient.GetById(id));

        }
    }
}