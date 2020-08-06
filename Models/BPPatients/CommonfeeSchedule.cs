using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class CommonfeeSchedule
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Scheduleid { get; set; }
        public int Itemid { get; set; }
        public int Amount { get; set; }
    }
}
