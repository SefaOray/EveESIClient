using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Contracts;
using System;
using System.Collections.Generic;

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
        public ESIResponse<List<GetCharacterContractsResponse>> GetCharacterContracts(string authToken, int characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/contracts/", authToken);

            return _client.Execute<List<GetCharacterContractsResponse>>(request);
        }

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="authToken">Access token to use </param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of bids</returns>
        public ESIResponse<List<GetCharacterContractBidsResponse>> GetCharacterContractBids(string authToken, int characterId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/contracts/{contractId}/bids/", authToken);

            return _client.Execute<List<GetCharacterContractBidsResponse>>(request);
        }

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="authToken">Access token to use </param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of items in this contract</returns>
        public ESIResponse<List<GetcharacterContractItemsResponse>> GetCharacterContractItems(string authToken, int characterId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/contracts/{contractId}/items/", authToken);

            return _client.Execute<List<GetcharacterContractItemsResponse>>(request);
        }

        /// <summary>
        /// Returns contracts available to a coporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
        /// </summary>
        /// <param name="authToken">Access token to use </param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return (Default is 0)</param>
        /// <returns>A list of contracts</returns>
        public ESIResponse<List<GetCorporationContractsResponse>> GetCorporationContracts(string authToken, int corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/contracts/", authToken);

            return _client.Execute<List<GetCorporationContractsResponse>>(request);
        }

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of bids</returns>
        public ESIResponse<List<GetCorporationContractBidsResponse>> GetCorporationContractBids(string authToken, int corporationId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/contracts/{contractId}/bids/", authToken);

            return _client.Execute<List<GetCorporationContractBidsResponse>>(request);
        }

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <returns>A list of items in this contract</returns>
        public ESIResponse<List<GetCorporationContractItemsResponse>> GetCorporationContractItems(string authToken, int corporationId, Int64 contractId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/contracts/{contractId}/items/", authToken);

            return _client.Execute<List<GetCorporationContractItemsResponse>>(request);
        }
    }
}