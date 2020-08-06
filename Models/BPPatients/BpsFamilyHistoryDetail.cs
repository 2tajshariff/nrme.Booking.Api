using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsFamilyHistoryDetail
    {
        public int InternalId { get; set; }
        public string RelationName { get; set; }
        public string Condition { get; set; }
        public int DiseaseCode { get; set; }
        public string Comment { get; set; }
    }
}
