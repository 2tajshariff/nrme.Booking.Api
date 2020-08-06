using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Careplandetail
    {
        public int Recordid { get; set; }
        public int Planid { get; set; }
        public int Recordstatus { get; set; }
        public int Cptype { get; set; }
        public int Review { get; set; }
        public string Currentplan { get; set; }
        public DateTime? Currentplandate { get; set; }
        public string Bywho { get; set; }
        public string Outcome { get; set; }
        public string Comments { get; set; }
        public int Interpret { get; set; }
        public int Purpose { get; set; }
        public int Patientcopy { get; set; }
        public int Consent { get; set; }
        public DateTime? Reviewdate { get; set; }
        public int Reminder { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Epcreports Plan { get; set; }
    }
}
