using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class UserNumbers
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int? UserId { get; set; }
        public int NumberType { get; set; }
        public string NumberValue { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Users User { get; set; }
    }
}
