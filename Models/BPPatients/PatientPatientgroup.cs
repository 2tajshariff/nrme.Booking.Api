using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientPatientgroup
    {
        public int Recordid { get; set; }
        public int Groupid { get; set; }
        public int Internalid { get; set; }

        public virtual Patientgroups Group { get; set; }
        public virtual Patients Internal { get; set; }
    }
}
