using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class LogPatientsIn
    {
        public string Computer { get; set; }
        public DateTime Processdate { get; set; }
        public int Processtime { get; set; }
        public int Processcode { get; set; }
        public int Linkcode { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public DateTime? Dob { get; set; }
        public string Externalid { get; set; }
        public int Internalid { get; set; }
    }
}
