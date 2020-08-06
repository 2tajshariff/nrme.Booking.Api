using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetcategorysource
    {
        public Factsheetcategorysource()
        {
            FactsheetcategoriesSources = new HashSet<FactsheetcategoriesSources>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FactsheetcategoriesSources> FactsheetcategoriesSources { get; set; }
    }
}
