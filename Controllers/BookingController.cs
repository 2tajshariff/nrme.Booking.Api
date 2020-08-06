using Microsoft.AspNetCore.Mvc;
using nrme.Booking.Api.Data;
using nrme.Booking.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nrme.Booking.Api.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly BookingRepository _bookingRepository;

        public BookingController(BookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
            
        [HttpGet]
        [Route("[controller]/BasicTest")]
        public ActionResult<IEnumerable<string>>  GetBasicTest()
        {
            return new string[] { "This","is","a","test" };
        }

        [HttpPost]
        [Route("[controller]/BookAppointment")]
        public async Task Post([FromBody] AppointmentEx appointment)
        {
            await _bookingRepository.Insert(appointment);
        }
    }
}
