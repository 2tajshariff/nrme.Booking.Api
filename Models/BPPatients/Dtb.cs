using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Dtb
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public DateTime? Opendate { get; set; }
        public int? Opentime { get; set; }
    }
}
