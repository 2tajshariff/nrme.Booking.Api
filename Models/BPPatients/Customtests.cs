using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Customtests
    {
        public int Testid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Testtype { get; set; }
        public string Testname { get; set; }
        public string Testcode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
