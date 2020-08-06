using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pcehrdocuments
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Stored { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public string Documentid { get; set; }
        public int Documenttype { get; set; }
        public DateTime? Documentdate { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Locationid { get; set; }
        public int Downloaded { get; set; }
        public int? CorroType { get; set; }
        public int? CorroId { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Users User { get; set; }
    }
}
