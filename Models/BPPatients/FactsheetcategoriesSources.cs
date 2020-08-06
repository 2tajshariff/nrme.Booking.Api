using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class FactsheetcategoriesSources
    {
        public int CategoryId { get; set; }
        public int SourceId { get; set; }

        public virtual Factsheetcategories Category { get; set; }
        public virtual Factsheetcategorysource Source { get; set; }
    }
}
