using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nrme.Booking.Api.Models
{
    public class AppointmentEx
    {
        public string AppointmentDate { get; set; }
        public int AppointmentTime { get; set; }
        public int AppointmentType { get; set; }
        public int AppointmentLength { get; set; }
        public int PractitionerId { get; set; }
        public int PatientId { get; set; }
        public string Reason { get; set; }
        public int LoginId { get; set; }
        public int LocationId { get; set; }
        public string VideoURL { get; set; }
    }
}
