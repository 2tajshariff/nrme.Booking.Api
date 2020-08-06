using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Accidentdiagnosis
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Claimid { get; set; }
        public int Injurycode { get; set; }
        public string Codesystem { get; set; }
        public string Description { get; set; }
        public int Sidecode { get; set; }

        public virtual Accident Claim { get; set; }
    }
}
