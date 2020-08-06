using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class EprescriptionLog
    {
        public int Logid { get; set; }
        public string Scid { get; set; }
        public string Message { get; set; }
        public string Messagetype { get; set; }
        public string Response { get; set; }
        public string Errors { get; set; }
        public int Createdby { get; set; }
        public DateTime Created { get; set; }
        public int Scriptid { get; set; }
        public byte? Recordstatus { get; set; }
    }
}
