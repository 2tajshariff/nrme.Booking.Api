using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Usergroups
    {
        public Usergroups()
        {
            Grouppermissions = new HashSet<Grouppermissions>();
            Users = new HashSet<Users>();
        }

        public int Groupcode { get; set; }
        public string Groupname { get; set; }
        public int Au { get; set; }
        public int Nz { get; set; }

        public virtual ICollection<Grouppermissions> Grouppermissions { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
