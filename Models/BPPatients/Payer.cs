using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Payer
    {
        public int Payerid { get; set; }
        public int Recordstatus { get; set; }
        public int Titlecode { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Titles TitlecodeNavigation { get; set; }
    }
}
