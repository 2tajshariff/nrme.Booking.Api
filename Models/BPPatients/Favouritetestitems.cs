using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Favouritetestitems
    {
        public int Recordid { get; set; }
        public int Favouriteid { get; set; }
        public int Testid { get; set; }
        public string Testname { get; set; }
        public string Labtestcode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Favouritetests Favourite { get; set; }
    }
}
