using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Leafletcategories
    {
        public Leafletcategories()
        {
            Educationleaflets = new HashSet<Educationleaflets>();
        }

        public int Categoryid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Parentcategory { get; set; }
        public string Categoryname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Educationleaflets> Educationleaflets { get; set; }
    }
}
