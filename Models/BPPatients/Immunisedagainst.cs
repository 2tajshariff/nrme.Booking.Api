using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Immunisedagainst
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public DateTime? Immunisationdate { get; set; }
        public string Vaccinename { get; set; }
        public int Diseaseid { get; set; }
        public int Sequence { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
