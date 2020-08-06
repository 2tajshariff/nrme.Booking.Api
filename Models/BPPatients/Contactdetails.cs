using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Contactdetails
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Contactid { get; set; }
        public int Addresscode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Hpio { get; set; }
        public string Hsdkey { get; set; }
        public DateTime? Hsdupdate { get; set; }
        public string Capabilities { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Hpiovalidated { get; set; }

        public virtual Contacts Contact { get; set; }
    }
}
