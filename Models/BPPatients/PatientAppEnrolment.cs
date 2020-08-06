using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientAppEnrolment
    {
        public int RecordId { get; set; }
        public int InternalId { get; set; }
        public int RecordStatus { get; set; }
        public int LocationId { get; set; }
        public int EnrolmentStatus { get; set; }
        public string PatientPublicKey { get; set; }
        public string MobileNumber { get; set; }
        public string PatientAppUsername { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public string AppVersion { get; set; }
    }
}
