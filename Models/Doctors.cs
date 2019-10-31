using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cs390914_MIS_SD.Models
{
    public class Doctors
    {
        [Key]
        public int DoctorID { get; set; }
        public string AreaOfPractice { get; set; }
        public DateTime DoctorSince { get; set; }
        public string DoctorPhone { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}