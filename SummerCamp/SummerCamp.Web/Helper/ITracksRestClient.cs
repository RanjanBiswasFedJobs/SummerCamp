using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SummerCamp.Model;

namespace SummerCamp.Web.Helper
{

    //Best to use generics here
   
    public interface ITracksRestClient
    {
        void Add(Track serverDataModel);
        void Delete(int id);
        IEnumerable<Track> GetAll();
        Track GetById(int id);
        Track GetByIP(int ip);
        Track GetByType(int type);
        void Update(Track serverDataModel);
    }
}