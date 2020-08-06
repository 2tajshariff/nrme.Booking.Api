﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Userreports
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Reportname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int AllUserAccess { get; set; }
        public int ReportId { get; set; }
        public DateTime? SavedStartDate { get; set; }
        public DateTime? SavedEndDate { get; set; }

        public virtual Users User { get; set; }
    }
}
