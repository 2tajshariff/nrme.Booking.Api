using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsImmunisations
    {
        public int InternalId { get; set; }
        public int Recordid { get; set; }
        public int UserId { get; set; }
        public DateTime? GivenDate { get; set; }
        public int NotGivenHere { get; set; }
        public string VaccineName { get; set; }
        public int VaccineId { get; set; }
        public string BatchNumber { get; set; }
        public int Sequence { get; set; }
        public int ConsentCode { get; set; }
        public int SiteCode { get; set; }
        public int Route { get; set; }
        public string Comment { get; set; }
        public DateTime? Vivasprinted { get; set; }
        public DateTime? Acirtransmitted { get; set; }
        public string Provider { get; set; }
        public DateTime Created { get; set; }
    }
}
