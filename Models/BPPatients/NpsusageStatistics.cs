using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class NpsusageStatistics
    {
        public int Recordid { get; set; }
        public string Documentid { get; set; }
        public int Referralcomponent { get; set; }
        public DateTime Viewdate { get; set; }
        public int Secondsonscreen { get; set; }
        public int Enduserid { get; set; }
        public string Producttype { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int Submitted { get; set; }
        public DateTime Submitteddate { get; set; }
    }
}
