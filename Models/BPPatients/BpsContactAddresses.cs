using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsContactAddresses
    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Greeting { get; set; }
        public string Category { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string SiteEmail { get; set; }
        public string SiteComment { get; set; }
        public string Ahphone { get; set; }
        public string MobilePhone { get; set; }
        public string Pager { get; set; }
        public string Email { get; set; }
        public string ProviderNo { get; set; }
        public string Abn { get; set; }
        public string Url { get; set; }
        public string Comment { get; set; }
    }
}
