using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Invoicenotes
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public string Notetext { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
