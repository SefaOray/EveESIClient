using RestSharp;

namespace EveESIClient.Client
{
    internal interface IHttpClient
    {
        ESIResponse<T> Execute<T>(RestRequest request) where T : new();
    }
}