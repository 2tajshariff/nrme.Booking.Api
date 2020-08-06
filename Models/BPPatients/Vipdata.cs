using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Vipdata
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public DateTime? Recorded { get; set; }
        public int Fieldid { get; set; }
        public string Fieldvalue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Vipfields Field { get; set; }
        public virtual Patients Internal { get; set; }
    }
}
