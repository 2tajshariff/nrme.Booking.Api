using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Printers
    {
        public int Recordid { get; set; }
        public string Computer { get; set; }
        public int Printercode { get; set; }
        public string Printer { get; set; }
        public int Paperbin { get; set; }
        public string Paperbinname { get; set; }
        public int Preview { get; set; }
        public int Prompt { get; set; }
        public int Xadjust { get; set; }
        public int Yadjust { get; set; }
        public int Landscape { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
