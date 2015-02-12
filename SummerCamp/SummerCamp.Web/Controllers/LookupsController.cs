using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using SummerCamp.Data.Contracts;
using SummerCamp.Model;
using System.Web.Mvc;
using CodeCamper.Web.Controllers;

namespace SummerCamp.Web.Controllers
{
    public class LookupsController : ApiControllerBase
    {
        public LookupsController(ISummerCampUow uow)
        {
            Uow = uow;
        }

        public LookupsController()
        {



        }
      
       // [ActionName("rooms")]
        public IEnumerable<Room> GetRooms()
        {

            return Uow.Rooms.GetAll().OrderBy(r => r.Name);
        }

       
        //[ActionName("timeslots")]
        public IEnumerable<TimeSlot> GetTimeSlots()
        {
            return Uow.TimeSlots.GetAll().OrderBy(ts => ts.Start);
        }

       
        //[ActionName("tracks")]
        public IEnumerable<Track> GetTracks()
        {
            return Uow.Tracks.GetAll().OrderBy(t => t.Name);
        }

       
       // [ActionName("all")]
        public Lookups GetLookups()
        {
            var lookups = new Lookups
            {
                Rooms = GetRooms().ToList(),
                TimeSlots = GetTimeSlots().ToList(),
                Tracks = GetTracks().ToList(),
            };
            return lookups;
        }



    }
}