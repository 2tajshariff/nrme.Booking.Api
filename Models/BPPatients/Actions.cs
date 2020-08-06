using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Actions
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public string Actiontext { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime Added { get; set; }
        public int Priority { get; set; }
        public int Actionstatus { get; set; }
        public DateTime? Performed { get; set; }
        public int Performedby { get; set; }
        public string Statustext { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Previoususerid { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
