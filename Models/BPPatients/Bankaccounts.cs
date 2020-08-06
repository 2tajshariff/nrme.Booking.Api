using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bankaccounts
    {
        public int Accountid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Bankname { get; set; }
        public string Accountname { get; set; }
        public string Accountnumber { get; set; }
        public string Bsbnumber { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Mid { get; set; }
    }
}
