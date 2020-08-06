using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class CdmNetsetup
    {
        public CdmNetsetup()
        {
            CdmNetvalue = new HashSet<CdmNetvalue>();
        }

        public int KeyTypeId { get; set; }
        public string KeyType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<CdmNetvalue> CdmNetvalue { get; set; }
    }
}
