using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reactions
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public int Itemtype { get; set; }
        public int Itemcode { get; set; }
        public string Itemname { get; set; }
        public int Reactioncode { get; set; }
        public string Reaction { get; set; }
        public int Severity { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? VisitId { get; set; }
        public int VisitUpdated { get; set; }
        public string Comment { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
