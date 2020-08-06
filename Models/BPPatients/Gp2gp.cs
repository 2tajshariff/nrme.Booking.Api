using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Gp2gp
    {
        public Gp2gp()
        {
            Gp2gpfields = new HashSet<Gp2gpfields>();
        }

        public int RecordId { get; set; }
        public string TransferId { get; set; }
        public int Version { get; set; }
        public int ReportId { get; set; }
        public int CorrespondenceId { get; set; }
        public int InternalId { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Patient { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users UpdatedByNavigation { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Gp2gpfields> Gp2gpfields { get; set; }
    }
}
