using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Gbrdisplayorder
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public int Contextid { get; set; }
        public int Displayorder { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
