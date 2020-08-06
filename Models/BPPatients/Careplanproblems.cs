using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Careplanproblems
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Planid { get; set; }
        public string Problem { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Epcreports Plan { get; set; }
    }
}
