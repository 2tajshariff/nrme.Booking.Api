using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class FactsheetsFactsheetcategories
    {
        public int FactSheetId { get; set; }
        public int CategoryId { get; set; }

        public virtual Factsheetcategories Category { get; set; }
        public virtual Factsheets FactSheet { get; set; }
    }
}
