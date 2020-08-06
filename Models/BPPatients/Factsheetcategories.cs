using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetcategories
    {
        public Factsheetcategories()
        {
            FactsheetcategoriesSources = new HashSet<FactsheetcategoriesSources>();
            FactsheetsFactsheetcategories = new HashSet<FactsheetsFactsheetcategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrimary { get; set; }

        public virtual ICollection<FactsheetcategoriesSources> FactsheetcategoriesSources { get; set; }
        public virtual ICollection<FactsheetsFactsheetcategories> FactsheetsFactsheetcategories { get; set; }
    }
}
