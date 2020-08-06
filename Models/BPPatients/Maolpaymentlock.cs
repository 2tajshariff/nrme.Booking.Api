using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Maolpaymentlock
    {
        public DateTime Lockdate { get; set; }
        public int Locktime { get; set; }
        public int Userid { get; set; }
        public string Computer { get; set; }

        public virtual Users User { get; set; }
    }
}
