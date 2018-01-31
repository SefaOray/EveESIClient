using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Client
{
    internal class ClientFactory
    {
        internal IHttpClient GetClient()
        {
            return new HttpClient();
        }
    }
}
