﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visitlesion
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Visitid { get; set; }
        public int Location { get; set; }
        public int Side { get; set; }
        public int Nature { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Colour { get; set; }
        public int Raised { get; set; }
        public int Ulcerated { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
