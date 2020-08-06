using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Servicenotes
    {
        public int Servicenoteid { get; set; }
        public int Serviceid { get; set; }
        public string Servicenote { get; set; }
    }
}
