using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsPatientLogin
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
