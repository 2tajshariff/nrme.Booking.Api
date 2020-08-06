using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Nirmessages
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int? InternalId { get; set; }
        public int? UserId { get; set; }
        public int? LocationId { get; set; }
        public int? ImmunisationId { get; set; }
        public int MessageType { get; set; }
        public string Details { get; set; }
        public string MessageId { get; set; }
        public int Status { get; set; }
        public int? AckCode { get; set; }
        public DateTime? AckDate { get; set; }
        public string AckComment { get; set; }
        public int SentOrReceived { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public int? Stored { get; set; }

        public virtual Immunisations Immunisation { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Users User { get; set; }
    }
}
