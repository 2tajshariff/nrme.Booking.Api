using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsBirths
    {
        public int PregnancyId { get; set; }
        public int InternalId { get; set; }
        public string Firstname { get; set; }
        public int Sex { get; set; }
        public string Weight { get; set; }
        public string Live { get; set; }
        public int Apgar1 { get; set; }
        public int Apgar5 { get; set; }
        public int BirthOrder { get; set; }
        public DateTime Created { get; set; }
    }
}
