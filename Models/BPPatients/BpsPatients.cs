using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsPatients
    {
        public int InternalId { get; set; }
        public string ExternalId { get; set; }
        public string StatusText { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public string Preferredname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCity { get; set; }
        public string PostalPostcode { get; set; }
        public DateTime? Dob { get; set; }
        public string Sex { get; set; }
        public string Ethnicity { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string MedicareNo { get; set; }
        public string MedicareLineNo { get; set; }
        public string MedicareExpiry { get; set; }
        public string PensionNo { get; set; }
        public DateTime? PensionStart { get; set; }
        public DateTime? PensionExpiry { get; set; }
        public string PensionType { get; set; }
        public string Dvano { get; set; }
        public string SafetyNetNo { get; set; }
        public string RecordNo { get; set; }
        public string Hchtier { get; set; }
        public DateTime? Hchstart { get; set; }
        public string Religion { get; set; }
        public string HealthFundName { get; set; }
        public string HealthFundNo { get; set; }
        public string Ihi { get; set; }
        public string UsualDoctor { get; set; }
    }
}
