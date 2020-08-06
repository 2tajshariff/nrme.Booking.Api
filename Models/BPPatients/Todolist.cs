using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Todolist
    {
        public int Recordid { get; set; }
        public int Todostatus { get; set; }
        public int Todotype { get; set; }
        public int Priority { get; set; }
        public int Userid { get; set; }
        public DateTime Entrydate { get; set; }
        public DateTime Duedate { get; set; }
        public int Internalid { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Previoususerid { get; set; }

        public virtual Users User { get; set; }
    }
}
