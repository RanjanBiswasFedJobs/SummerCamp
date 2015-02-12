using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCamper.Data.SampleData;
using SummerCamp.Data.Configuration;
using SummerCamp.Model;

namespace SummerCamp.Data
{
    public class SummerCampDbContext : DbContext
    {
        static SummerCampDbContext()
        {
            Database.SetInitializer(new CodeCamperDatabaseInitializer());
        }


        public SummerCampDbContext()
            : base(nameOrConnectionString: "SummerCamp") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new SessionConfiguration());
            modelBuilder.Configurations.Add(new AttendanceConfiguration());
        }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Attendance> Attendance { get; set; }

        // Lookup Lists
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Track> Tracks { get; set; }


    }
}
