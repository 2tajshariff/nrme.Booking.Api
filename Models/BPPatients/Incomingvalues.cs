using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Incomingvalues
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Reportid { get; set; }
        public DateTime? Reportdate { get; set; }
        public string Datatype { get; set; }
        public string Loinccode { get; set; }
        public int Bpcode { get; set; }
        public string Resultname { get; set; }
        public string Resultvalue { get; set; }
        public string Units { get; set; }
        public string Range { get; set; }
        public string Abnormalflag { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Incomingreports Report { get; set; }
    }
}
