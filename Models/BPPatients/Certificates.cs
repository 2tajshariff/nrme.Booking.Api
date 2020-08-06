using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Certificates
    {
        public int Recordid { get; set; }
        public int Certificatetype { get; set; }
        public string Filename { get; set; }
        public string Serialnumber { get; set; }
        public string Password { get; set; }
        public byte[] Certificate { get; set; }
    }
}
