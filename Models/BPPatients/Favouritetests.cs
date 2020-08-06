using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Favouritetests
    {
        public Favouritetests()
        {
            Favouritetestitems = new HashSet<Favouritetestitems>();
        }

        public int Favouriteid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Labcode { get; set; }
        public string Favouritename { get; set; }
        public int Favouriteno { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Favouritetestitems> Favouritetestitems { get; set; }
    }
}
