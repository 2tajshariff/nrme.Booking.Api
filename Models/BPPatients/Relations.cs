using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Relations
    {
        public Relations()
        {
            Familyhistorydetail = new HashSet<Familyhistorydetail>();
        }

        public int Relationcode { get; set; }
        public string Relationname { get; set; }

        public virtual ICollection<Familyhistorydetail> Familyhistorydetail { get; set; }
    }
}
