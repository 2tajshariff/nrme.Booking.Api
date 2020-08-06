using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Npsdetails
    {
        public int Detailid { get; set; }
        public int Userid { get; set; }
        public int Productid { get; set; }
        public int Timesseen { get; set; }
        public int Dontshow { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Consentprompt { get; set; }
    }
}
