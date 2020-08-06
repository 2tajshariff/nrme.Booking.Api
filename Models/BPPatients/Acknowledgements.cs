using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Acknowledgements
    {
        public int Recordid { get; set; }
        public string Facility { get; set; }
        public int Acknowledge { get; set; }
        public string Ackpath { get; set; }
    }
}
