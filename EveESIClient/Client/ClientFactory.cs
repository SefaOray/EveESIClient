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