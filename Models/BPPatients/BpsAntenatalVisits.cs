using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAntenatalVisits
    {
        public int InternalId { get; set; }
        public int PregnancyId { get; set; }
        public DateTime VisitDate { get; set; }
        public string Weight { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int SizeByDates { get; set; }
        public int ClinicalSize { get; set; }
        public int FundusHeight { get; set; }
        public string FoetalHeartHeard { get; set; }
        public int FoetalHeartRate { get; set; }
        public string FoetalMovements { get; set; }
        public string AnkleOedema { get; set; }
        public string UrineProtein { get; set; }
        public string UrineGlucose { get; set; }
        public string UrineOther { get; set; }
        public string Presentation { get; set; }
        public string Position { get; set; }
        public string Engagement { get; set; }
        public string Comment { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
