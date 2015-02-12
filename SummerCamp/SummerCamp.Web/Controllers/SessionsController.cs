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
    public class SessionsController : ApiControllerBase
    {

        public SessionsController(ISummerCampUow uow)
        {
            Uow = uow;
        }


        // GET /api/sessions
        public IEnumerable<Session> Get()
        {
            return Uow.Sessions.GetAll()
                .OrderBy(s => s.TimeSlotId);
        }

        // GET /api/sessions/5
        public Session Get(int id)
        {
            var session = Uow.Sessions.GetById(id);
            if (session != null) return session;
            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        }

        /// <summary>
        /// Create a new Session
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public HttpResponseMessage Post(Session session)
        {
            Uow.Sessions.Add(session);
            Uow.Commit();

            var response = Request.CreateResponse(HttpStatusCode.Created, session);

            response.Headers.Location =
                new Uri(Url.Link(WebApiConfig.ControllerAndId, new { id = session.Id }));

            return response;
        }

        // Update an existing Session
        // PUT /api/sessions/
        public HttpResponseMessage Put(Session session)
        {
            Uow.Sessions.Update(session);
            Uow.Commit();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        // DELETE /api/sessions/5
        public HttpResponseMessage Delete(int id)
        {
            Uow.Sessions.Delete(id);
            Uow.Commit();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }



    }
}
