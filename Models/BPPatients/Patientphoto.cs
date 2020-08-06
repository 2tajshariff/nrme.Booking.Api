using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Patientphoto
    {
        public int Photoid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Stored { get; set; }
        public int Current { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
