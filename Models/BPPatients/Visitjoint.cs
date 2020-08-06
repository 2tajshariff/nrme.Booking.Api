using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visitjoint
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Visitid { get; set; }
        public int Joint { get; set; }
        public int Side { get; set; }
        public int Flexion { get; set; }
        public int Extension { get; set; }
        public int Llatflexion { get; set; }
        public int Rlatflexion { get; set; }
        public int Introtation { get; set; }
        public int Extrotation { get; set; }
        public int Stiffness { get; set; }
        public int Crepitus { get; set; }
        public int Stability { get; set; }
        public int Effusion { get; set; }
        public int Redness { get; set; }
        public int Heat { get; set; }
        public int Tenderness { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
