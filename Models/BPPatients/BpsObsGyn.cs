using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsObsGyn
    {
        public int InternalId { get; set; }
        public DateTime? LastPapSmearDate { get; set; }
        public string LastPapSmearResult { get; set; }
        public string NotForSmears { get; set; }
        public string BreastFeeding { get; set; }
        public string GravidityKnown { get; set; }
        public int? Gravidity { get; set; }
        public int? Parity { get; set; }
        public int? Miscarriages { get; set; }
        public int? Terminations { get; set; }
        public DateTime? Lnmp { get; set; }
        public DateTime? EdcbyDate { get; set; }
        public DateTime? EdcbyScan { get; set; }
        public int CurrentPregnancyId { get; set; }
    }
}
