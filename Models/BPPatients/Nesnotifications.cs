using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Nesnotifications
    {
        public Nesnotifications()
        {
            NesnotificationParameters = new HashSet<NesnotificationParameters>();
        }

        public int NotificationId { get; set; }
        public int Nesid { get; set; }
        public int InternalId { get; set; }
        public DateTime NotificationDate { get; set; }
        public DateTime Imported { get; set; }
        public string ServiceName { get; set; }
        public string OperationName { get; set; }
        public string Reason { get; set; }
        public int Status { get; set; }
        public DateTime? LastPoll { get; set; }
        public string LastError { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual NesnotificationStatus StatusNavigation { get; set; }
        public virtual ICollection<NesnotificationParameters> NesnotificationParameters { get; set; }
    }
}
