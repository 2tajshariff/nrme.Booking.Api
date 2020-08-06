using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Permissiontypes
    {
        public int Recordid { get; set; }
        public int Permissiontype { get; set; }
        public string Permissiontext { get; set; }
        public int Permissionvalue { get; set; }
    }
}
