using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Rooms
    {
        public Rooms()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int Roomid { get; set; }
        public int Locationid { get; set; }
        public string Roomname { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
