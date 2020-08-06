using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Tobacco
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Smokingcode { get; set; }
        public int Smokingtype { get; set; }
        public int Smokesperday { get; set; }
        public int Yearstarted { get; set; }
        public int Pastsmokingcode { get; set; }
        public int Pastsmokesperday { get; set; }
        public int Paststarted { get; set; }
        public int Paststopped { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Cessation { get; set; }
        public int Advice { get; set; }
        public int Medication { get; set; }
        public int Support { get; set; }
        public int Referral { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
