using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Search
{
    public class SearchClient
    {
        private readonly IHttpClient _httpClient;
        internal SearchClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Search for entities that match a given sub-string
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="categories">Type of entities to search for</param>
        /// <param name="language">Language to use in the response</param>
        /// <param name="search">The string to search on</param>
        /// <param name="strict">Whether the search should be a strict match</param>
        /// <returns>A list of search results</returns>
        public ESIResponse<SearchResponse> Search(string authToken, int characterId, string search, string[] categories, string language, bool? strict)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/search/", authToken);
            request.AddParameter("search", search, RestSharp.ParameterType.QueryString);
            request.AddParameter("categories", categories, RestSharp.ParameterType.QueryString);
            request.AddParameter("language", language, RestSharp.ParameterType.QueryString);
            request.AddParameter("strict", strict, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<SearchResponse>(request);
        }

        /// <summary>
        /// Search for entities that match a given sub-string
        /// </summary>
        /// <param name="categories">Type of entities to search for</param>
        /// <param name="language">Language to use in the response</param>
        /// <param name="search">The string to search on</param>
        /// <param name="strict">Whether the search should be a strict match</param>
        /// <returns>A list of search results</returns>
        public ESIResponse<SearchResponse> Search(string search, string[] categories, string language, bool? strict)
        {
            var request = RestRequestHelper.CreateGetRequest($"search/");
            request.AddParameter("search", search, RestSharp.ParameterType.QueryString);
            request.AddParameter("categories", categories, RestSharp.ParameterType.QueryString);
            request.AddParameter("language", language, RestSharp.ParameterType.QueryString);
            request.AddParameter("strict", strict, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<SearchResponse>(request);
        }
    }
}
