using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pasthistory
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Itemtext { get; set; }
        public int Itemcode { get; set; }
        public int Statuscode { get; set; }
        public int Locationcode { get; set; }
        public int Positioncode { get; set; }
        public int Descriptioncode { get; set; }
        public int Severitycode { get; set; }
        public int Acutecode { get; set; }
        public int Privacycode { get; set; }
        public int Summarycode { get; set; }
        public int Fracture { get; set; }
        public int Displaced { get; set; }
        public int Compound { get; set; }
        public int Comminuted { get; set; }
        public int Spiral { get; set; }
        public int Greenstick { get; set; }
        public string Mom { get; set; }
        public string Mompath { get; set; }
        public string Details { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Pcehr { get; set; }
        public int Provisional { get; set; }
        public int? VisitId { get; set; }
        public int VisitUpdated { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
