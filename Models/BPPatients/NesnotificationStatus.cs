using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class NesnotificationStatus
    {
        public NesnotificationStatus()
        {
            Nesnotifications = new HashSet<Nesnotifications>();
        }

        public int StatusCode { get; set; }
        public string StatusText { get; set; }

        public virtual ICollection<Nesnotifications> Nesnotifications { get; set; }
    }
}
