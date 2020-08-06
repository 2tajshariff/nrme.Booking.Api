using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsCurrentRx
    {
        public int InternalId { get; set; }
        public string DrugName { get; set; }
        public string Dose { get; set; }
        public string Frequency { get; set; }
        public string Food { get; set; }
        public string OtherDetail { get; set; }
        public string Prn { get; set; }
        public string Instructions { get; set; }
        public int Route { get; set; }
        public int Quantity { get; set; }
        public string ProductUnit { get; set; }
        public int Repeats { get; set; }
        public string Indication { get; set; }
        public DateTime? FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        public int ProductId { get; set; }
        public string Scid { get; set; }
        public int Scidno { get; set; }
        public DateTime Created { get; set; }
        public int Recordid { get; set; }
    }
}
