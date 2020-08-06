using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetshistory
    {
        public int UserId { get; set; }
        public int FactSheetId { get; set; }
        public DateTime Date { get; set; }

        public virtual Factsheets FactSheet { get; set; }
    }
}
