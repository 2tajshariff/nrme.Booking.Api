using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Ihihistory
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public string Ihi { get; set; }
        public int Ihistatus { get; set; }
        public int Ihirecordstatus { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Ihisource { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
