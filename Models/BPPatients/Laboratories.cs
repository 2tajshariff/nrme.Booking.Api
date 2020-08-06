using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Laboratories
    {
        public int Recordid { get; set; }
        public int Labid { get; set; }
        public int Userid { get; set; }
        public int Requestformat { get; set; }
        public int Plainpaper { get; set; }
        public int Labels { get; set; }
        public int Labeloffset { get; set; }
        public int Duplicateoffset { get; set; }
        public int Patientcopy { get; set; }
        public int Txcode { get; set; }
        public string Programname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string EformDefaultUrl { get; set; }

        public virtual Requestformats RequestformatNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
