using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerCamp.Model;

namespace SummerCamp.Data.Contracts
{
    public interface ISessionsRepository : IRepository<Session>
    {
      
        IQueryable<SessionBrief> GetSessionBriefs();

        IEnumerable<TagGroup> GetTagGroups();
    }
}
