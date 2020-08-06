using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Permissions
    {
        public Permissions()
        {
            Grouppermissions = new HashSet<Grouppermissions>();
        }

        public int Permissioncode { get; set; }
        public int Permissiontype { get; set; }
        public string Description { get; set; }
        public int Displayorder { get; set; }
        public string Permissionname { get; set; }

        public virtual ICollection<Grouppermissions> Grouppermissions { get; set; }
    }
}
