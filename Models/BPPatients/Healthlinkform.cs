using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Healthlinkform
    {
        public string Sessionkey { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public string Formstatus { get; set; }
        public string Resumepath { get; set; }
        public string Data { get; set; }
        public int? Viewid { get; set; }
        public bool Completed { get; set; }
        public int? Visitid { get; set; }
        public int Locationid { get; set; }
        public string Subject { get; set; }
        public string Addressee { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Messageid { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
