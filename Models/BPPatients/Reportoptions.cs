using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reportoptions
    {
        public int Recordid { get; set; }
        public string Optionname { get; set; }
        public int Optionvalue { get; set; }
        public string Optiontext { get; set; }
        public string Computer { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
