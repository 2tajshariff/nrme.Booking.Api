using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Login
    {
        public int Recordid { get; set; }
        public string Computer { get; set; }
        public int Userid { get; set; }
        public DateTime? Logintime { get; set; }
        public DateTime? Logouttime { get; set; }

        public virtual Users User { get; set; }
    }
}
