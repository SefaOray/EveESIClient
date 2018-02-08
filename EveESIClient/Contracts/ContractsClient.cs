using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Contracts;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Contracts
{
    public class ContractsClient
    {
        private readonly IHttpClient _client;
        internal ContractsClient(IHttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns contracts available to a character, only if the character is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of contracts</returns>
        public ESIResponse<List<GetCharacterContractsResponse>> GetCharacterContracts(string authToken, Int64 characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/contracts/", Method.GET, authToken);

            return _client.Execute<List<GetCharacterContractsResponse>>(request);
        }

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="authToken">Access token to use </param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of bids</returns>
        public ESIResponse<List<GetCharacterContractBidsResponse>> GetCharacterContractBids(string authToken, Int64 characterId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/contracts/{contractId}/bids/", Method.GET, authToken);

            return _client.Execute<List<GetCharacterContractBidsResponse>>(request);
        }

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="authToken">Access token to use </param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of items in this contract</returns>
        public ESIResponse<List<GetcharacterContractItemsResponse>> GetCharacterContractItems(string authToken, Int64 characterId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/contracts/{contractId}/items/", Method.GET, authToken);

            return _client.Execute<List<GetcharacterContractItemsResponse>>(request);
        }

        /// <summary>
        /// Returns contracts available to a coporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
        /// </summary>
        /// <param name="authToken">Access token to use </param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of contracts</returns>
        public ESIResponse<List<GetCorporationContractsResponse>> GetCorporationContracts(string authToken, Int64 corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/contracts/", Method.GET, authToken);

            return _client.Execute<List<GetCorporationContractsResponse>>(request);
        }

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of bids</returns>
        public ESIResponse<List<GetCorporationContractBidsResponse>> GetCorporationContractBids(string authToken, Int64 corporationId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/contracts/{contractId}/bids/", Method.GET, authToken);

            return _client.Execute<List<GetCorporationContractBidsResponse>>(request);
        }

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of items in this contract</returns>
        public ESIResponse<List<GetCorporationContractItemsResponse>> GetCorporationContractItems(string authToken, Int64 corporationId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"corporations/{corporationId}/contracts/{contractId}/items/", Method.GET, authToken);

            return _client.Execute<List<GetCorporationContractItemsResponse>>(request);
        }
    }
}
