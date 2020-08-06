using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class QueueConfigurations
    {
        public int ConfigurationId { get; set; }
        public string QueueName { get; set; }
        public int MaxRetries { get; set; }
        public int RetryInterval { get; set; }
        public string MachineName { get; set; }
        public string HandlerName { get; set; }
        public int RecordStatus { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
