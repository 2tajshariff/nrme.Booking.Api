using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Healthelink
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public string Accountname { get; set; }
        public string Receivingfacility { get; set; }
        public int Allowreenrol { get; set; }
        public int Forcereason { get; set; }
        public int Resend { get; set; }
        public int Retries { get; set; }
        public int Helcode { get; set; }
        public int Serveronly { get; set; }
        public int Resenddays { get; set; }
        public string Loginurl { get; set; }
    }
}
