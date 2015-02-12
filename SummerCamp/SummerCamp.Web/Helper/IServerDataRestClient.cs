using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SummerCamp.Model;

namespace SummerCamp.Web.Helper
{
    public interface IServerDataRestClient
    {
        void Add(Session serverDataModel);
        void Delete(int id);
        IEnumerable<Session> GetAll();
        Session GetById(int id);
        Session GetByIP(int ip);
        Session GetByType(int type);
        void Update(Session serverDataModel);
    }
}