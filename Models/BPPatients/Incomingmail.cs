using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Incomingmail
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public int Internalid { get; set; }
        public int Inboxid { get; set; }
        public string Addressee { get; set; }
        public string Sender { get; set; }
        public string Senderemail { get; set; }
        public string Subject { get; set; }
        public int Priority { get; set; }
        public DateTime? Sentdate { get; set; }
        public DateTime? Recvdate { get; set; }
        public string Copies { get; set; }
        public string Bcc { get; set; }
        public string Bodytext { get; set; }
        public string Attachments { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Previoususerid { get; set; }
    }
}
