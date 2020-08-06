using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Carer
    {
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Titlecode { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Contactphone { get; set; }
        public string Contactphone2 { get; set; }
        public string Relationship { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Titles TitlecodeNavigation { get; set; }
    }
}
