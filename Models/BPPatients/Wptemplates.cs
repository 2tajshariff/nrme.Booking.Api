using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Wptemplates
    {
        public Wptemplates()
        {
            Templatefaves = new HashSet<Templatefaves>();
        }

        public int Templateid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Templatename { get; set; }
        public int Supplied { get; set; }
        public int State { get; set; }
        public int Category { get; set; }
        public string Pagesettings { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Templatefaves> Templatefaves { get; set; }
    }
}
