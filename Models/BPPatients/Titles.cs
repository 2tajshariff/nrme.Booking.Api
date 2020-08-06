using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Titles
    {
        public Titles()
        {
            Carer = new HashSet<Carer>();
            Contacts = new HashSet<Contacts>();
            Nextofkin = new HashSet<Nextofkin>();
            Patients = new HashSet<Patients>();
            Payer = new HashSet<Payer>();
            Users = new HashSet<Users>();
            Workcoverdetails = new HashSet<Workcoverdetails>();
        }

        public int Titlecode { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Carer> Carer { get; set; }
        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<Nextofkin> Nextofkin { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
        public virtual ICollection<Payer> Payer { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<Workcoverdetails> Workcoverdetails { get; set; }
    }
}
