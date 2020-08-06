using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Medview
    {
        public int Recordid { get; set; }
        public int Active { get; set; }
        public string Server { get; set; }
        public int Port { get; set; }
        public string Statement { get; set; }
    }
}
