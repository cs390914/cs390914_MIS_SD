using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cs390914_MIS_SD.Models;
using System.Data.Entity;

namespace cs390914_MIS_SD.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
    }
}