using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Medrefercorrespondence
    {
        public int Recordid { get; set; }
        public int Correspondenceoutid { get; set; }
        public int Recipientid { get; set; }
        public int? Actionedbyrecipient { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Medreferstatus { get; set; }
        public string Medreferid { get; set; }
        public int? Correspondenceinid { get; set; }
        public string Recipientname { get; set; }
        public string Certificateurl { get; set; }

        public virtual Correspondenceout Correspondenceout { get; set; }
    }
}
