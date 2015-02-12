using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerCamp.Model
{
    public class Session : SessionBrief
    {
      
        public string Description { get; set; }

        public virtual Person Speaker { get; set; }
        public virtual Track Track { get; set; }
        public virtual TimeSlot TimeSlot { get; set; }
        public virtual Room Room { get; set; }


        //Multiple Attendace
        public virtual ICollection<Attendance>
            AttendanceList { get; set; }
    }
}
