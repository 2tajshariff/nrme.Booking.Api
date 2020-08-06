using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Uhgreportsquestions
    {
        public int Reportquestionid { get; set; }
        public int Reportid { get; set; }
        public int Questionid { get; set; }

        public virtual Uhgquestion Question { get; set; }
        public virtual Uhgreport Report { get; set; }
    }
}
