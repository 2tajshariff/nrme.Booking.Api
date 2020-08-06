using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Referrals
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Contactid { get; set; }
        public int Detailid { get; set; }
        public DateTime Referraldate { get; set; }
        public DateTime? Expirydate { get; set; }
        public int Referralcode { get; set; }
        public int Months { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Specialist { get; set; }
        public DateTime? Firstvisit { get; set; }
        public int? Previoususerid { get; set; }

        public virtual Contacts Contact { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
