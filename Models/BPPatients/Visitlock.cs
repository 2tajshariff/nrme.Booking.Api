using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visitlock
    {
        public int Recordid { get; set; }
        public int Visitid { get; set; }
        public int Userid { get; set; }
        public string Computer { get; set; }

        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
