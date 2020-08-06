using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Patientgroups
    {
        public Patientgroups()
        {
            PatientPatientgroup = new HashSet<PatientPatientgroup>();
        }

        public int Groupid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Groupname { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<PatientPatientgroup> PatientPatientgroup { get; set; }
    }
}
