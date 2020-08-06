using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Sonicpath
    {
        public int Recordid { get; set; }
        public int Nata { get; set; }
        public int Pathtype { get; set; }
        public string Computer { get; set; }
        public string Filepath { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
