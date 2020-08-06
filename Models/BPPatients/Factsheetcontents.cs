using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetcontents
    {
        public int FactSheetId { get; set; }
        public string Language { get; set; }
        public string FileUrl { get; set; }

        public virtual Factsheets FactSheet { get; set; }
    }
}
