using RestSharp;

namespace EveESIClient.Client
{
    internal class HttpClient : IHttpClient
    {
        public ESIResponse<T> Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(ESIClient.ClientConfiguration.ApiUri);
            var response = client.Execute<T>(request);

            var esiResponse = new ESIResponse<T>()
            {
                IsSuccessful = response.IsSuccessful,
                StatusCode = (int)response.StatusCode,
                Data = response.IsSuccessful ? response.Data : default(T)
            };

            return esiResponse;
        }
    }
}