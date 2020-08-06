using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class FhircategoryMapping
    {
        public string ExternalCode { get; set; }
        public int CategoryCode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Categories CategoryCodeNavigation { get; set; }
    }
}
