using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientWhitecoat
    {
        public int InternalId { get; set; }
        public string WhitecoatPhone { get; set; }
        public int WhitecoatStatus { get; set; }
        public int? WhitecoatId { get; set; }
        public int? WhitecoatHasOshc { get; set; }
        public string WhitecoatInsurerName { get; set; }
        public string WhitecoatPolicyNumber { get; set; }
        public int? WhitecoatPolicyIndividualReference { get; set; }
        public int? WhitecoatPolicyCoveredPersonId { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
