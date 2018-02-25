using EveESIClient.Client;
using EveESIClient.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Routes
{
    public class RoutesClient
    {
        private readonly IHttpClient _httpClient;
        internal RoutesClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Get the systems between origin and destination
        /// </summary>
        /// <param name="origin">origin solar system ID</param>
        /// <param name="destination">destination solar system ID</param>
        /// <param name="flag">route security preference</param>
        /// <param name="avoid">avoid solar system ID(s)</param>
        /// <param name="connections">connected solar system pairs</param>
        /// <returns>Solar systems in route from origin to destination</returns>
        public ESIResponse<List<int>> GetRoute(int origin, int destination, string flag, int[][] avoid, int[] connections)
        {
            var request = RestRequestHelper.CreateGetRequest($"route/{origin}/{destination}/");
            request.AddParameter("avoid", avoid, RestSharp.ParameterType.QueryString);
            request.AddParameter("connections", connections, RestSharp.ParameterType.QueryString);
            request.AddParameter("flag", flag, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<int>>(request);
        }
    }
}
