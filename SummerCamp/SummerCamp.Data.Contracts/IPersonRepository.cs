using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerCamp.Model;

namespace SummerCamp.Data.Contracts
{
    public interface IPersonsRepository : IRepository<Person>
    {  
        IQueryable<Speaker> GetSpeakers();

    }
}
