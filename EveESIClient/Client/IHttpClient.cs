using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Client
{
    internal interface IHttpClient
    {
        ESIResponse<T> Execute<T>(RestRequest request) where T : new();
    }
}
