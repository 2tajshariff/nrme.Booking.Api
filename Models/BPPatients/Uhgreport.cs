using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Uhgreport
    {
        public Uhgreport()
        {
            Uhganswer = new HashSet<Uhganswer>();
            Uhgreanswer = new HashSet<Uhgreanswer>();
            Uhgreportsquestions = new HashSet<Uhgreportsquestions>();
            Uhgselectedinformation = new HashSet<Uhgselectedinformation>();
        }

        public int Reportid { get; set; }
        public int Recordstatus { get; set; }
        public long Uhgid { get; set; }
        public int Internalid { get; set; }
        public string Reportfile { get; set; }
        public int Status { get; set; }
        public DateTime Dateimported { get; set; }
        public DateTime? Datesubmitted { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Updatedby { get; set; }
        public int Incomingreportid { get; set; }
        public int? Userid { get; set; }
        public int? Previoususerid { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual ICollection<Uhganswer> Uhganswer { get; set; }
        public virtual ICollection<Uhgreanswer> Uhgreanswer { get; set; }
        public virtual ICollection<Uhgreportsquestions> Uhgreportsquestions { get; set; }
        public virtual ICollection<Uhgselectedinformation> Uhgselectedinformation { get; set; }
    }
}
