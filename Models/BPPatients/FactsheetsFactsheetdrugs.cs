using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class FactsheetsFactsheetdrugs
    {
        public int FactSheetId { get; set; }
        public int FactSheetDrugId { get; set; }

        public virtual Factsheets FactSheet { get; set; }
        public virtual Factsheetdrugs FactSheetDrug { get; set; }
    }
}
