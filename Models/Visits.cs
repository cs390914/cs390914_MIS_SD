using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cs390914_MIS_SD.Models
{
    public class Visits
    {
        public int VisitID { get; set; }
        public string ReasonForVisit { get; set; }
        public DateTime VisitDate { get; set; }

        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}