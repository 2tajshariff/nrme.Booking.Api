using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Testitems
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Requestid { get; set; }
        public string Testcode { get; set; }
        public string Testname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Requestedtests Request { get; set; }
    }
}
