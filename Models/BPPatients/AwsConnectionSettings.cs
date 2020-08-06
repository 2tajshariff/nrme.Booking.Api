using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class AwsConnectionSettings
    {
        public string Environment { get; set; }
        public string ApiClientId { get; set; }
        public string UserPoolId { get; set; }
        public string IdentityPoolId { get; set; }
        public string S3serviceUrl { get; set; }
        public string ApiGatewayUrl { get; set; }
        public string LogoCache { get; set; }
    }
}
