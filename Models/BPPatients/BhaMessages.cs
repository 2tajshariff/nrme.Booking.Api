using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BhaMessages
    {
        public BhaMessages()
        {
            BhaReplies = new HashSet<BhaReplies>();
        }

        public int BhaMessageId { get; set; }
        public string Title { get; set; }
        public string MessageBody { get; set; }
        public int InternalId { get; set; }
        public int? AttachmentId { get; set; }
        public int? AttachmentStored { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public string MessageGuid { get; set; }
        public int? TemplateId { get; set; }

        public virtual ICollection<BhaReplies> BhaReplies { get; set; }
    }
}
