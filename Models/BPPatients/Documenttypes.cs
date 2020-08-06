using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Documenttypes
    {
        public int Documenttypeid { get; set; }
        public int Recordstatus { get; set; }
        public string Category { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
