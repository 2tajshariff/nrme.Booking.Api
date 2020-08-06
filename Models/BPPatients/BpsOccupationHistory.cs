using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsOccupationHistory
    {
        public int InternalId { get; set; }
        public string OccupationName { get; set; }
        public string Description { get; set; }
        public string Employer { get; set; }
        public int YearStarted { get; set; }
        public int YearStopped { get; set; }
        public string Asbestos { get; set; }
        public string Dust { get; set; }
        public string Radiation { get; set; }
        public string Animals { get; set; }
        public string Comment { get; set; }
        public int Adfstatus { get; set; }
    }
}
