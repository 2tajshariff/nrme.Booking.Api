using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Uhgquestion
    {
        public Uhgquestion()
        {
            Uhganswer = new HashSet<Uhganswer>();
            Uhgreportsquestions = new HashSet<Uhgreportsquestions>();
        }

        public int Questionid { get; set; }
        public string Questiontext { get; set; }
        public int Uhgquestionid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Uhganswer> Uhganswer { get; set; }
        public virtual ICollection<Uhgreportsquestions> Uhgreportsquestions { get; set; }
    }
}
