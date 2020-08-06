using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bponline
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public string Computer { get; set; }
        public string Bppath { get; set; }
    }
}
