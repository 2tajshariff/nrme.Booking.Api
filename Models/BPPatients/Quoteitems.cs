using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Quoteitems
    {
        public int Quoteitemid { get; set; }
        public int Recordstatus { get; set; }
        public int Practiceid { get; set; }
        public int Userid { get; set; }
        public string Quoteitemcode { get; set; }
        public string Description { get; set; }
        public int Fee { get; set; }
        public int Refund { get; set; }
        public int Gst { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
