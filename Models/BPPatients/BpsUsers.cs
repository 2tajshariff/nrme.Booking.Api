using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsUsers
    {
        public int UserId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string RegistrationNo { get; set; }
        public string ProviderNo { get; set; }
        public string PrescriberNo { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Pager { get; set; }
        public string Abn { get; set; }
        public string Title { get; set; }
        public string GroupName { get; set; }
        public string LocationName { get; set; }
    }
}
