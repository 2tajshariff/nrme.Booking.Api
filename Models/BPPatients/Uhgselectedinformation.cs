using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Uhgselectedinformation
    {
        public int Id { get; set; }
        public int Reportid { get; set; }
        public int Recordid { get; set; }
        public int Type { get; set; }

        public virtual Uhgreport Report { get; set; }
    }
}
