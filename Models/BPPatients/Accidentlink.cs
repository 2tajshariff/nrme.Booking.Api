using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Accidentlink
    {
        public int Claimid { get; set; }
        public int Appointmentid { get; set; }
        public int Visitid { get; set; }

        public virtual Accident Claim { get; set; }
    }
}
