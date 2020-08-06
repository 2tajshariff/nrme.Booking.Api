using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Opdose
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Opioidid { get; set; }
        public DateTime? Opdate { get; set; }
        public string Dose { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Stopped { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Opioid Opioid { get; set; }
    }
}
