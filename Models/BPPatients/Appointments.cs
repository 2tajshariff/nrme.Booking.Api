using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Appointments
    {
        public Appointments()
        {
            PatientPresence = new HashSet<PatientPresence>();
        }

        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public int Visitid { get; set; }
        public DateTime Appointmentdate { get; set; }
        public int Appointmenttime { get; set; }
        public int Appointmentlength { get; set; }
        public int Appointmentcode { get; set; }
        public int Appointmenttype { get; set; }
        public int Urgent { get; set; }
        public string Reason { get; set; }
        public int Arrivaltime { get; set; }
        public int Consultationtime { get; set; }
        public int Visitlength { get; set; }
        public int Roomid { get; set; }
        public int Operationid { get; set; }
        public int Bookedby { get; set; }
        public int Accounttype { get; set; }
        public int Nnac { get; set; }
        public int Patients { get; set; }
        public string Itemlist { get; set; }
        public string Comment { get; set; }
        public int? Remindersent { get; set; }
        public DateTime? Remindersentdate { get; set; }
        public int? Remindersentuserid { get; set; }
        public int? Attendanceconfirmed { get; set; }
        public DateTime? Attendanceupdated { get; set; }
        public int? Attendanceupdatedby { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Followup { get; set; }
        public string Videourl { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Rooms Room { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<PatientPresence> PatientPresence { get; set; }
    }
}
