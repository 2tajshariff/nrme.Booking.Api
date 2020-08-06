using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Transactions
    {
        public Guid Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public int Status { get; set; }
        public int Processor { get; set; }
        public string Payload { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Payments Payment { get; set; }
    }
}
