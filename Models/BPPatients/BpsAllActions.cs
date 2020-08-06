using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAllActions
    {
        public int InternalId { get; set; }
        public int Recordid { get; set; }
        public string ActionText { get; set; }
        public int RecordStatus { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Added { get; set; }
        public int Priority { get; set; }
        public string Performed { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
