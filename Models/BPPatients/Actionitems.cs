using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Actionitems
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public string Itemtext { get; set; }
        public int Displayorder { get; set; }
        public int Au { get; set; }
        public int Nz { get; set; }
    }
}
