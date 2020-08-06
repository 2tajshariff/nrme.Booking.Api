using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsAlcohol
    {
        public int InternalId { get; set; }
        public string NonDrinker { get; set; }
        public int DaysPerweek { get; set; }
        public int DrinksPerday { get; set; }
        public string Description { get; set; }
        public string PastAlcoholLevel { get; set; }
        public int YearStarted { get; set; }
        public int YearStopped { get; set; }
        public string Comment { get; set; }
    }
}
