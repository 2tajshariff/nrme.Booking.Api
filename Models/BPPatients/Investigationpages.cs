using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Investigationpages
    {
        public int Investigationpageid { get; set; }
        public int Reportid { get; set; }
        public int Pagenumber { get; set; }
        public string Pagesettings { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Investigations Report { get; set; }
    }
}
