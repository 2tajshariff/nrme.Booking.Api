using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Defaultdose
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public int Productid { get; set; }
        public string Dose { get; set; }
        public int Frequency { get; set; }
        public int Food { get; set; }
        public int Otherdetail { get; set; }
        public int Route { get; set; }
        public int Prn { get; set; }
        public string Instructions { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
