using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Occupationhistory
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public string Employer { get; set; }
        public string Description { get; set; }
        public string Occupation { get; set; }
        public int Occupationcode { get; set; }
        public int Yearstarted { get; set; }
        public int Yearstopped { get; set; }
        public int Asbestos { get; set; }
        public int Dust { get; set; }
        public int Radiation { get; set; }
        public int Animal { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Principal { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Occupations OccupationcodeNavigation { get; set; }
    }
}
