using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reportpaths
    {
        public int Recordid { get; set; }
        public string Computer { get; set; }
        public string Reportpath { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Recordstatus { get; set; }
        public DateTime? Created { get; set; }
        public int Createdby { get; set; }
        public int Invalidaccessattempts { get; set; }
    }
}
