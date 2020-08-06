using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Messagestatus
    {
        public int Statuscode { get; set; }
        public string Description { get; set; }
        public int Methodcode { get; set; }

        public virtual ContactMethod MethodcodeNavigation { get; set; }
    }
}
