using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Erx
    {
        public int Recordid { get; set; }
        public string Filename { get; set; }
        public string Password { get; set; }
        public string Thumbprint { get; set; }
        public byte[] Certificate { get; set; }
    }
}
