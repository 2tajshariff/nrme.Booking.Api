﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visitparameters
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Visitid { get; set; }
        public int Parameterid { get; set; }
        public int Parametervalue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
