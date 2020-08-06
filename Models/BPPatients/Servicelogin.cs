using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Servicelogin
    {
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string OrganisationId { get; set; }
        public int? RecordStatus { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
