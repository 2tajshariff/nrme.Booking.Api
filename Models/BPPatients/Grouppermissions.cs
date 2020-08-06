using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Grouppermissions
    {
        public int Recordid { get; set; }
        public int Groupcode { get; set; }
        public int Permissioncode { get; set; }
        public int Permissionlevel { get; set; }

        public virtual Usergroups GroupcodeNavigation { get; set; }
        public virtual Permissions PermissioncodeNavigation { get; set; }
    }
}
