using System;

namespace nrme.Booking.Api.Models
{
    public class Booking
    {
        public int Id {get;set;}
        public DateTime AppointmentDateTime {get;set;}
        public string AppointmentType{get;set;}
        
    }
}