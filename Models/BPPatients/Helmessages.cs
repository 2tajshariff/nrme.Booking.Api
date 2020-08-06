using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Helmessages
    {
        public int Messageid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Messagedate { get; set; }
        public DateTime? Lastsent { get; set; }
        public int Resends { get; set; }
        public int Acknowledged { get; set; }
        public DateTime? Ackdate { get; set; }
        public string Message { get; set; }
    }
}
