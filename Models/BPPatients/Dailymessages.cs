using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Dailymessages
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Messagedate { get; set; }
        public string Message { get; set; }
        public int Locationid { get; set; }
    }
}
