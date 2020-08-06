using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class ImmunisationIndicationLink
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int ImmunisationRecordId { get; set; }
        public int IndicationId { get; set; }
        public DateTime? Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
