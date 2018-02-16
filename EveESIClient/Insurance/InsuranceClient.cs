using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Insurance;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Insurance
{
    public class InsuranceClient
    {
        private readonly IHttpClient _httpClient;
        internal InsuranceClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Return available insurance levels for all ship types
        /// </summary>
        /// <returns>A list of insurance levels for all ship types</returns>
        public ESIResponse<List<GetInsuranceLevelsResponse>> GetInsuranceLevels()
        {
            var request = RestRequestHelper.CreateGetRequest($"insurance/prices/");

            return _httpClient.Execute<List<GetInsuranceLevelsResponse>>(request);
        }
    }
}
