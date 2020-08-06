using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Messages
    {
        public int Recordid { get; set; }
        public int Messageid { get; set; }
        public int Messagestatus { get; set; }
        public int Priority { get; set; }
        public int Userid { get; set; }
        public int Fromid { get; set; }
        public int Internalid { get; set; }
        public DateTime Messagedate { get; set; }
        public int Messagetime { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Previoususerid { get; set; }

        public virtual Users User { get; set; }
    }
}
