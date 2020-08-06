using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Familyhistory
    {
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Adopted { get; set; }
        public int Patalive { get; set; }
        public int Patageatdeath { get; set; }
        public string Patcauseofdeath { get; set; }
        public int Patcauseofdeathcode { get; set; }
        public int Matalive { get; set; }
        public int Matageatdeath { get; set; }
        public string Matcauseofdeath { get; set; }
        public int Matcauseofdeathcode { get; set; }
        public string Fhcomment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
