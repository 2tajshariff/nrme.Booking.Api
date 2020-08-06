using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Linkpaths
    {
        public string Computer { get; set; }
        public int Readlink { get; set; }
        public string Inpath { get; set; }
        public string Outpath { get; set; }
        public string Visitspath { get; set; }
        public string Immpath { get; set; }
        public string Scriptpath { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
