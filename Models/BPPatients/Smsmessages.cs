using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Smsmessages
    {
        public Smsmessages()
        {
            Smsreplies = new HashSet<Smsreplies>();
        }

        public int Smsid { get; set; }
        public string Messageid { get; set; }
        public int Recordid { get; set; }
        public string Senttext { get; set; }
        public string Replytext { get; set; }
        public int? Deliverystatus { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Requirestatus { get; set; }
        public string Mobile { get; set; }

        public virtual ICollection<Smsreplies> Smsreplies { get; set; }
    }
}
