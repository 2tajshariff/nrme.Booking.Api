using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nrme.Booking.Api.Data
{
    public class BookingRepository
    {
        private readonly string _connectionString;
        public BookingRepository(IConfiguration configuration)
        {
            //_connectionString = configuration.GetConnectionString("DbConnectionString");
            _connectionString = "Server=DESKTOP-UG65FTO\\BPSINSTANCE;Database=BPSPatients;User ID=BPSRawData;Password=Ghada123;";
        }

        //EXEC @return_value = [dbo].[BP_AddAppointmentEx]

        //@aptdate = N'20191204',
        //@apttime = 29700,
        //@appointmenttype = 1,
        //@aptlen = 900,
        //@practitionerid = 12, --Doctor 1
        //@patientid = 9, -- Patient Id

        //@reason = N'test',
        //@loginid = 12, --Doctor 1
        //@locationid = 1,
        //@videourl = NULL
        public async Task Insert(Booking.Api.Models.AppointmentEx appointment)
        {
            using(SqlConnection sql = new SqlConnection(_connectionString))
            {
                using(SqlCommand cmd = new SqlCommand("BP_AddAppointmentEx", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@aptdate", appointment.AppointmentDate));
                    cmd.Parameters.Add(new SqlParameter("@apttime", appointment.AppointmentTime));
                    cmd.Parameters.Add(new SqlParameter("@appointmenttype", appointment.AppointmentType));
                    cmd.Parameters.Add(new SqlParameter("@aptlen", appointment.AppointmentLength));
                    cmd.Parameters.Add(new SqlParameter("@practitionerid", appointment.PractitionerId));
                    cmd.Parameters.Add(new SqlParameter("@patientid", appointment.PatientId));
                    cmd.Parameters.Add(new SqlParameter("@reason", appointment.Reason));
                    cmd.Parameters.Add(new SqlParameter("@loginid", appointment.LoginId));
                    cmd.Parameters.Add(new SqlParameter("@locationid", appointment.LocationId));
                    cmd.Parameters.Add(new SqlParameter("@videourl", appointment.VideoURL));
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    return;
                }
            }
        }
    }
}
