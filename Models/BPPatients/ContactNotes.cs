using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class ContactNotes
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int InternalId { get; set; }
        public int ContactNoteReasonId { get; set; }
        public int ContactMethodId { get; set; }
        public string Details { get; set; }
        public int Number { get; set; }
        public int Status { get; set; }
        public int? ContinuePatientEnrolment { get; set; }
        public DateTime ContactDate { get; set; }
        public string Message { get; set; }
        public int? OriginLinkId { get; set; }
        public long? MessageId { get; set; }
        public int? ContactWith { get; set; }
        public int? ContactType { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public int Locationid { get; set; }

        public virtual ContactMethod ContactMethod { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Locations Location { get; set; }
    }
}
