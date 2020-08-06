using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetuserfavourites
    {
        public int FactSheetId { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Factsheets FactSheet { get; set; }
    }
}
