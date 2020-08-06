using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsClinical
    {
        public int InternalId { get; set; }
        public string KnownAllergies { get; set; }
        public string NoSignificantPastHistory { get; set; }
        public string NoSignificantFamilyHistory { get; set; }
        public string SmokingStatus { get; set; }
        public string BloodGroup { get; set; }
        public string Retired { get; set; }
        public string MaritalStatusName { get; set; }
        public string SexualityName { get; set; }
        public string EliteSports { get; set; }
        public string PaceMaker { get; set; }
        public string SocialHistory { get; set; }
        public string Recreation { get; set; }
        public string AccomodationText { get; set; }
        public string LivesWithText { get; set; }
        public string HasCarer { get; set; }
        public string IsCarer { get; set; }
        public int? AdvanceCareDirective { get; set; }
        public int? PowerOfAttorney { get; set; }
    }
}
