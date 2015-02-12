using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerCamp.Model;

namespace SummerCamp.Data.Contracts
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        IQueryable<Attendance> GetByPersonId(int id);
        IQueryable<Attendance> GetBySessionId(int id);
        Attendance GetByIds(int personId, int sessionId);
        void Delete(int personId, int sessionId);
    }
}
