using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetdrugs
    {
        public Factsheetdrugs()
        {
            FactsheetsFactsheetdrugs = new HashSet<FactsheetsFactsheetdrugs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FactsheetsFactsheetdrugs> FactsheetsFactsheetdrugs { get; set; }
    }
}
