using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeCamper.Web.Controllers;
using SummerCamp.Data.Contracts;
using SummerCamp.Model;

namespace SummerCamp.Web.Controllers
{
    public class TracksController : ApiControllerBase
    {
        public TracksController(ISummerCampUow uow)
        {
            Uow = uow;
        }

        public IEnumerable<Track> Get()
        {
            return Uow.Tracks.GetAll()
                .OrderBy(s => s.Name);
        }


        // GET /api/sessions/5
        public Track Get(int id)
        {
            var track = Uow.Tracks.GetById(id);
            if (track != null) return track;
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        }


    }
}
