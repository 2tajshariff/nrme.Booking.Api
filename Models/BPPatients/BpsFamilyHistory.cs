using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsFamilyHistory
    {
        public int InternalId { get; set; }
        public string Unknown { get; set; }
        public string FatherAlive { get; set; }
        public int FathersAgeAtDeath { get; set; }
        public string FathersCauseOfDeath { get; set; }
        public string MotherAlive { get; set; }
        public int MothersAgeAtDeath { get; set; }
        public string MothersCauseOfDeath { get; set; }
        public string Comment { get; set; }
    }
}
