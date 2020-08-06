using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class LogReports
    {
        public DateTime Processdate { get; set; }
        public int Processcode { get; set; }
        public int Loggedinid { get; set; }
        public string Addressee { get; set; }
        public string Testname { get; set; }
        public DateTime? Requestdate { get; set; }
        public DateTime? Collectiondate { get; set; }
        public DateTime? Reportdate { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public DateTime? Dob { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
    }
}
