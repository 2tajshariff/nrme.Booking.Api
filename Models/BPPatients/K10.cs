using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class K10
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public DateTime K10date { get; set; }
        public int Q1 { get; set; }
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public int Q5 { get; set; }
        public int Q6 { get; set; }
        public int Q7 { get; set; }
        public int Q8 { get; set; }
        public int Q9 { get; set; }
        public int Q10 { get; set; }
        public int Score { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
