using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Labels
    {
        public int Recordid { get; set; }
        public string Labelname { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Leftmargin { get; set; }
        public int Rightmargin { get; set; }
        public int Topmargin { get; set; }
        public int Bottommargin { get; set; }
        public int Fontsize { get; set; }
        public string Fontname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
