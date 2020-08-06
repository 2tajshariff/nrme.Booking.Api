using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Careplantasks
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Planid { get; set; }
        public string Task { get; set; }
        public DateTime? Datedue { get; set; }
        public string Actioned { get; set; }
        public DateTime? Actiondate { get; set; }
        public int Actioncode { get; set; }
        public string Actiontext { get; set; }
        public string Provider { get; set; }
        public int Providerid { get; set; }
        public int Providercode { get; set; }
        public int Detailid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Epcreports Plan { get; set; }
    }
}
