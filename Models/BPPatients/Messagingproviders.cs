using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Messagingproviders
    {
        public Messagingproviders()
        {
            Defaultmessaging = new HashSet<Defaultmessaging>();
            Ereferrals = new HashSet<Ereferrals>();
        }

        public int Messagingproviderid { get; set; }
        public int Recordstatus { get; set; }
        public string Providername { get; set; }
        public string Accountid { get; set; }
        public string Pathin { get; set; }
        public string Pathout { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Usecda { get; set; }

        public virtual ICollection<Defaultmessaging> Defaultmessaging { get; set; }
        public virtual ICollection<Ereferrals> Ereferrals { get; set; }
    }
}
