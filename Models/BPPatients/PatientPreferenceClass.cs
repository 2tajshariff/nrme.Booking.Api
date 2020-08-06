using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientPreferenceClass
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public string PereferenceCategoryCode { get; set; }
        public string QuestionClass { get; set; }
        public int DisplayOrder { get; set; }
        public string QuestionText { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public decimal CillectionVersion { get; set; }
    }
}
