using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Popdetails
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public string Popserver { get; set; }
        public string Popusername { get; set; }
        public string Popuserid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
