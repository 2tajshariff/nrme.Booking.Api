using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Extrasessions
    {
        public int Sessionid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public DateTime Sessiondate { get; set; }
        public int Starttime { get; set; }
        public int Endtime { get; set; }
        public int Length { get; set; }
        public int Special { get; set; }
        public string Label { get; set; }
        public int Rgb { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
