using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Educationleaflets
    {
        public int Leafletid { get; set; }
        public int Recordstatus { get; set; }
        public int Stored { get; set; }
        public int Userid { get; set; }
        public int Categoryid { get; set; }
        public string Leafletname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Leafletcategories Category { get; set; }
        public virtual Users User { get; set; }
    }
}
