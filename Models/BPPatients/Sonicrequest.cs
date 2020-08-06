using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Sonicrequest
    {
        public int Recordid { get; set; }
        public int Requestid { get; set; }
        public string Barcode { get; set; }
        public DateTime Created { get; set; }
    }
}
