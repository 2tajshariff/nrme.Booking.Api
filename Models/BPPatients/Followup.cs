using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Followup
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime? Commentdate { get; set; }
        public int Commenttime { get; set; }
        public int Userid { get; set; }
        public int Resultid { get; set; }
        public int Resulttype { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Converted { get; set; }
    }
}
