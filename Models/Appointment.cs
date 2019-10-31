using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cs390914_MIS_SD.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        public string ReasonForVisit { get; set; }
        public DateTime AppointmentDate { get; set; }

        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}