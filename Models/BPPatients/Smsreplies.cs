using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Smsreplies
    {
        public int SmsreplyId { get; set; }
        public string MessageId { get; set; }
        public int SmsmessageId { get; set; }
        public string ReplyText { get; set; }
        public DateTime ReceivedReply { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Smsmessages Smsmessage { get; set; }
    }
}
