using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Helpath
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Pathtype { get; set; }
        public string Computer { get; set; }
        public string Hlpath { get; set; }
    }
}
