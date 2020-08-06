using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientEnrolments
    {
        public int Recordid { get; set; }
        public int? Recordtype { get; set; }
        public int? Enrolmentid { get; set; }
        public int Internalid { get; set; }
        public string Mode { get; set; }
        public string HealthServiceCode { get; set; }
        public int? Status { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Expirydate { get; set; }
        public string TerminationReasonCode { get; set; }
        public DateTime? ReenrolmentDate { get; set; }
        public DateTime? LastEncounterDate { get; set; }
        public string EnrollingOrganisationId { get; set; }
        public string EnrollingOrganisationName { get; set; }
        public string ServiceOrganisationId { get; set; }
        public string ServicePractitionerCpn { get; set; }
        public string ServicePractiionerName { get; set; }
        public string ServiceFacilityId { get; set; }
        public string AuthenticatedOrgid { get; set; }
        public DateTime? Localprocessingdate { get; set; }
        public DateTime? Created { get; set; }
        public int? Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
