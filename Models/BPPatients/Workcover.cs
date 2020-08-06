using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Workcover
    {
        public Workcover()
        {
            Workcoveritems = new HashSet<Workcoveritems>();
            Workcovertext = new HashSet<Workcovertext>();
        }

        public int Certificateid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public int Pmcid { get; set; }
        public string Pmc { get; set; }
        public string Claimid { get; set; }
        public DateTime? Certificatedate { get; set; }
        public DateTime? Certificatetime { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Workcoveritems> Workcoveritems { get; set; }
        public virtual ICollection<Workcovertext> Workcovertext { get; set; }
    }
}
