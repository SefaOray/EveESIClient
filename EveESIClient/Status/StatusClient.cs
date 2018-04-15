using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Status;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Status
{
    public class StatusClient
    {
        private readonly IHttpClient _httpClient;
        internal StatusClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// EVE Server status
        /// </summary>
        /// <returns>Server status</returns>
        public ESIResponse<GetStatusResponse> GetStatus()
        {
            var request = RestRequestHelper.CreateGetRequest($"status/");

            return _httpClient.Execute<GetStatusResponse>(request);
        }
    }
}
