using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAllPapSmears
    {
        public int InternalId { get; set; }
        public DateTime PapDate { get; set; }
        public int Recordstatus { get; set; }
        public string Result { get; set; }
        public int Recordid { get; set; }
        public string Csttype { get; set; }
        public string Hpv16 { get; set; }
        public string Hpv18 { get; set; }
        public string Hpvother { get; set; }
        public string Hpv { get; set; }
        public string EndocervicalCells { get; set; }
        public string PerformedBy { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
    }
}
