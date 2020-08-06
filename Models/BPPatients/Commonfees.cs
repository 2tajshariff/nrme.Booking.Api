using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Commonfees
    {
        public int Itemid { get; set; }
        public int Recordstatus { get; set; }
        public int Itemcode { get; set; }
        public int Userid { get; set; }
        public int Mbsitem { get; set; }
        public string Description { get; set; }
        public int Gst { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
