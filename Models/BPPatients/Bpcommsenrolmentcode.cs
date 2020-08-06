using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bpcommsenrolmentcode
    {
        public int Internalid { get; set; }
        public int Type { get; set; }
        public DateTime Sentdate { get; set; }
        public string Enrolmentcode { get; set; }
    }
}
