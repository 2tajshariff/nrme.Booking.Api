using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsServices
    {
        public int Serviceid { get; set; }
        public int Internalid { get; set; }
        public DateTime? Servicedate { get; set; }
        public int Mbsitem { get; set; }
        public string Description { get; set; }
    }
}
