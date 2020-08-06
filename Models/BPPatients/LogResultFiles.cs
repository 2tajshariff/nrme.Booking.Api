using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class LogResultFiles
    {
        public string Filename { get; set; }
        public string Computer { get; set; }
        public DateTime Processdate { get; set; }
        public int Processcode { get; set; }
        public int Reportcount { get; set; }
    }
}
