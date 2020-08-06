using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class AzureEventHubSettings
    {
        public int AzureEventHubSettingsId { get; set; }
        public int RecordStatus { get; set; }
        public string Description { get; set; }
        public string EventHubName { get; set; }
        public string EndPointUrl { get; set; }
        public string SharedAccessKeyName { get; set; }
        public string SharedAccessKey { get; set; }
        public string Environment { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
