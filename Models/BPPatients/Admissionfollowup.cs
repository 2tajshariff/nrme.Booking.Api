﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Admissionfollowup
    {
        public int Recordid { get; set; }
        public int Admissionid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime? Followupdate { get; set; }
        public string Followuptime { get; set; }
        public string Followupwhen { get; set; }
        public string Followupwith { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
