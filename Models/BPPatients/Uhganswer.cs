using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Uhganswer
    {
        public int Answerid { get; set; }
        public int Recordstatus { get; set; }
        public int Reportid { get; set; }
        public int Questionid { get; set; }
        public string Answer { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Uhgquestion Question { get; set; }
        public virtual Uhgreport Report { get; set; }
    }
}
