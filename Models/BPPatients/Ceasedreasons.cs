using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Ceasedreasons
    {
        public int Reasoncode { get; set; }
        public int Recordstatus { get; set; }
        public string Reason { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
