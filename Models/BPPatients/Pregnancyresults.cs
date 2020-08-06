using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pregnancyresults
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Pregnancyid { get; set; }
        public string Testname { get; set; }
        public int Sequence { get; set; }
        public int Resultid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Pregnancies Pregnancy { get; set; }
    }
}
