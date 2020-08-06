using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visitreason
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Visitid { get; set; }
        public string Reason { get; set; }
        public string Reasoncode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Locationcode { get; set; }
        public int Positioncode { get; set; }
        public int Descriptioncode { get; set; }
        public int Severitycode { get; set; }
        public int Acutecode { get; set; }
        public int Fracture { get; set; }
        public int Displaced { get; set; }
        public int Compound { get; set; }
        public int Comminuted { get; set; }
        public int Spiral { get; set; }
        public int Greenstick { get; set; }
        public string Condition { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
