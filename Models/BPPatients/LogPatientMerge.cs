using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class LogPatientMerge
    {
        public int Patient1 { get; set; }
        public int Patient2 { get; set; }
        public DateTime Mergedate { get; set; }
        public int Userid { get; set; }
    }
}
