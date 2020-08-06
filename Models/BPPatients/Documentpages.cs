using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Documentpages
    {
        public int Documentpageid { get; set; }
        public int Documentid { get; set; }
        public int Pagenumber { get; set; }
        public string Pagesettings { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Correspondencein Document { get; set; }
    }
}
