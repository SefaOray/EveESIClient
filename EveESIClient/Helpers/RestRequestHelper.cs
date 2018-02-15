using RestSharp;

namespace EveESIClient.Helpers
{
    internal static class RestRequestHelper
    {
        internal static RestRequest CreateGetRequest(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.GET);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);

            return request;
        }

        internal static RestRequest CreateAuthorizedGetRequest(string endpoint, string authToken)
        {
            var request = new RestRequest(endpoint, Method.GET);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);
            request.AddHeader("token", authToken);

            return request;
        }

        internal static RestRequest CreateAuthorizedPutRequest(string endpoint, string authToken)
        {
            var request = new RestRequest(endpoint, Method.PUT);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);
            request.AddHeader("token", authToken);

            return request;
        }

        internal static RestRequest CreateAuthorizedPostRequest(string endpoint, string authToken)
        {
            var request = new RestRequest(endpoint, Method.POST);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);
            request.AddHeader("token", authToken);

            return request;
        }

        internal static RestRequest CreatePostRequest(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.POST);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);

            return request;
        }

        internal static RestRequest CreateAuthorizedDeleteRequest(string endpoint, string authToken)
        {
            var request = new RestRequest(endpoint, Method.DELETE);
            request.AddHeader("X-User-Agent", ESIClient.ClientConfiguration.XUserAgent);
            request.AddHeader("token", authToken);

            return request;
        }
    }
}