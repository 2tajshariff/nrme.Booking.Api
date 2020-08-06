using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheets
    {
        public Factsheets()
        {
            Factsheetcontents = new HashSet<Factsheetcontents>();
            FactsheetsFactsheetcategories = new HashSet<FactsheetsFactsheetcategories>();
            FactsheetsFactsheetdrugs = new HashSet<FactsheetsFactsheetdrugs>();
            Factsheetshistory = new HashSet<Factsheetshistory>();
            Factsheetuserfavourites = new HashSet<Factsheetuserfavourites>();
        }

        public int Id { get; set; }
        public string DetailViewUrl { get; set; }
        public string EmailFactsheetUrl { get; set; }
        public string Avatar { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsPaid { get; set; }
        public string SponsorName { get; set; }
        public string State { get; set; }
        public string HealthFund { get; set; }
        public int? GroupId { get; set; }
        public int TypeId { get; set; }

        public virtual Factsheetgroups Group { get; set; }
        public virtual Factsheettypes Type { get; set; }
        public virtual ICollection<Factsheetcontents> Factsheetcontents { get; set; }
        public virtual ICollection<FactsheetsFactsheetcategories> FactsheetsFactsheetcategories { get; set; }
        public virtual ICollection<FactsheetsFactsheetdrugs> FactsheetsFactsheetdrugs { get; set; }
        public virtual ICollection<Factsheetshistory> Factsheetshistory { get; set; }
        public virtual ICollection<Factsheetuserfavourites> Factsheetuserfavourites { get; set; }
    }
}
