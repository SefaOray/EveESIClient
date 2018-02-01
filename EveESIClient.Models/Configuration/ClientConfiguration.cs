

using System;

namespace EveESIClient.Models.Configuration
{
    public class ClientConfiguration
    {
        /// <summary>
        /// datasource parameter when making calls to ESI.
        /// Tranquility: Live server.
        /// Singularity: Test server.
        /// Tranquility is default.
        /// </summary>
        public ClientTarget DataSource { get; set; } = ClientTarget.Tranquility;

        /// <summary>
        /// Custom X-User-Agent parameter.
        /// </summary>
        public string XUserAgent { get; set; } = "EveESIClient";

        /// <summary>
        /// Default is 'https://esi.tech.ccp.is'
        /// Set this property if you want to target custom route eg:
        /// https://esi.tech.ccp.is/dev/
        /// https://esi.tech.ccp.is/legacy/
        /// https://esi.tech.ccp.is/v1/
        /// </summary>
        public Uri ApiUri { get; set;  } = new Uri("https://esi.tech.ccp.is/latest/");
    }
}