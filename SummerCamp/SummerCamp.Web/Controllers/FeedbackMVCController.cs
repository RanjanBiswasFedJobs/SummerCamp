using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SummerCamp.Model;

namespace SummerCamp.Web.Controllers
{
    public class FeedbackMVCController : Controller
    {
        // GET: FeedbackMVC
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public void SubmitFeedback(Feedback feedback)
        {



        }
    }
}