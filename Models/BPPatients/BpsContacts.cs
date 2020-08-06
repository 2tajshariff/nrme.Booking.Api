using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsContacts
    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Greeting { get; set; }
        public string Category { get; set; }
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
