using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class CdmNetvalue
    {
        public int KeyTypeId { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public virtual CdmNetsetup KeyType { get; set; }
    }
}
