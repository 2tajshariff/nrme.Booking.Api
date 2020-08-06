using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Adfoccupation
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Adfcode { get; set; }
        public int Adfprompt { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
