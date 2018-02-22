using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Market;
using System.Collections.Generic;

namespace EveESIClient.Market
{
    public class MarketClient
    {
        private readonly IHttpClient _httpClient;
        internal MarketClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// List market orders placed by a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Market orders placed by a character</returns>
        public ESIResponse<List<GetCharacterOpenOrdersResponse>> GetCharacterOpenOrders(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/orders/", authToken);

            return _httpClient.Execute<List<GetCharacterOpenOrdersResponse>>(request);
        }

        /// <summary>
        /// List cancelled and expired market orders placed by a character up to 90 days in the past
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>Expired and cancelled market orders placed by a character</returns>
        public ESIResponse<List<GetCharacterOrderHistoryResponse>> GetCharacterOrderHistory(string authToken, int characterId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/orders/history/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCharacterOrderHistoryResponse>>(request);
        }

        /// <summary>
        /// List open market orders placed on behalf of a corporation
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>A list of open market orders</returns>
        public ESIResponse<List<GetCorporationOpenOrdersResponse>> GetCorporationOpenOrders(string authToken, int corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/orders/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCorporationOpenOrdersResponse>>(request);
        }

        /// <summary>
        /// List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>Expired and cancelled market orders placed on behalf of a corporation</returns>
        public ESIResponse<List<GetCorporationOrderHistoryResponse>> GetCorporationOrderHistory(string authToken, int corporationId, int page = 0)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"corporations/{corporationId}/orders/history/", authToken);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetCorporationOrderHistoryResponse>>(request);
        }

        /// <summary>
        /// Return a list of historical market statistics for the specified type in a region
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="typeId">Return statistics for this type</param>
        /// <returns>A list of historical market statistics</returns>
        public ESIResponse<List<GetRegionMarketStatisticsResponse>> GetRegionMarketStatistics(int regionId, int typeId)
        {
            var request = RestRequestHelper.CreateGetRequest($"markets/{regionId}/history/");
            request.AddParameter("type_id", typeId, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetRegionMarketStatisticsResponse>>(request);
        }

        /// <summary>
        /// Return a list of orders in a region
        /// </summary>
        /// <param name="regionId">Return orders in this region</param>
        /// <param name="orderType">Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders</param>
        /// <param name="typeId">Return orders only for this type</param>
        /// <param name="page">Which page of results to return</param>
        /// <returns>A list of orders</returns>
        public ESIResponse<List<GetOrdersInRegionResponse>> GetOrdersInRegion(int regionId, string orderType, int? typeId, int? page)
        {
            var request = RestRequestHelper.CreateGetRequest($"markets/{regionId}/orders/");
            request.AddParameter("type_id", typeId, RestSharp.ParameterType.QueryString);
            request.AddParameter("order_type", orderType, RestSharp.ParameterType.QueryString);
            request.AddParameter("page", page, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetOrdersInRegionResponse>>(request);
        }

        /// <summary>
        /// Return a list of type IDs that have active orders in the region, for efficient market indexing
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <returns>A list of type IDs</returns>
        public ESIResponse<List<int>> ListTypeIds(int regionId)
        {
            var request = RestRequestHelper.CreateGetRequest($"markets/{regionId}/types/");

            return _httpClient.Execute<List<int>>(request);
        }

        /// <summary>
        /// Get a list of item groups
        /// </summary>
        /// <returns>A list of item group ids</returns>
        public ESIResponse<List<int>> GetItemGroups()
        {
            var request = RestRequestHelper.CreateGetRequest($"markets/groups/");

            return _httpClient.Execute<List<int>>(request);
        }

        /// <summary>
        /// Get information on an item group
        /// </summary>
        /// <param name="itemGroup">An Eve item group ID</param>
        /// <returns>Information about an item group</returns>
        public ESIResponse<GetItemGroupInformationResponse> GetItemGroupInformation(int itemGroup)
        {
            var request = RestRequestHelper.CreateGetRequest($"markets/groups/{itemGroup}/");

            return _httpClient.Execute<GetItemGroupInformationResponse>(request);
        }

        /// <summary>
        /// Return a list of prices
        /// </summary>
        /// <returns>A list of prices</returns>
        public ESIResponse<List<GetMarketPricesResponse>> GetMarketPrices()
        {
            var request = RestRequestHelper.CreateGetRequest($"markets/prices/");

            return _httpClient.Execute<List<GetMarketPricesResponse>>(request);
        }

        /// <summary>
        /// Return all orders in a structure
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="structureId">Return orders in this structure</param>
        /// <returns>A list of orders</returns>
        public ESIResponse<List<GetOrdersInStructureResponse>> GetOrdersInStructure(string authToken, int structureId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"markets/structures/{structureId}/", authToken);

            return _httpClient.Execute<List<GetOrdersInStructureResponse >>(request);
        }
    }
}
