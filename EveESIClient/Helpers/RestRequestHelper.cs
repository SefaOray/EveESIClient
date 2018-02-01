using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace EveESIClient.Helpers
{
    internal static class RestRequestHelper
    {
        internal static RestRequest CreateRestRequest(string endpoint, Method method)
        {
            var request = new RestRequest(endpoint, method);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);

            return request;
        }

        internal static RestRequest CreateAuthrorizedRestRequest(string endpoint, Method method, string authToken)
        {
            var request = new RestRequest(endpoint, method);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);
            request.AddHeader("token", authToken);

            return request;
        }
    }
}
