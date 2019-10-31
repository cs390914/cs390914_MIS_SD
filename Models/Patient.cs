using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cs390914_MIS_SD.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime PatientSince { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}