using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bpremote
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public string Server { get; set; }
        public DateTime? Downloadtime { get; set; }
    }
}
