using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Uhgreanswer
    {
        public int Id { get; set; }
        public int Reportid { get; set; }
        public string Answer { get; set; }

        public virtual Uhgreport Report { get; set; }
    }
}
