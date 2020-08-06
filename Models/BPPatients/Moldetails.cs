using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Moldetails
    {
        public int Recordid { get; set; }
        public int? Locationid { get; set; }
        public string Locationcode { get; set; }
        public string CertificateId { get; set; }
        public string PassPhrase { get; set; }
        public string ProxyPassword { get; set; }
        public string ProxyId { get; set; }
        public int? Status { get; set; }
        public string Email { get; set; }
    }
}
