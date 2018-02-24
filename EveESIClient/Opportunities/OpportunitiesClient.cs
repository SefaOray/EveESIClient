using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Opportunities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Opportunities
{
    public class OpportunitiesClient
    {
        private readonly IHttpClient _httpClient;
        internal OpportunitiesClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Return a list of tasks finished by a character
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of opportunities task ids</returns>
        public ESIResponse<List<GetCharactersCompletedTasksResponse>> GetCharactersCompletedTasks(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/opportunities/", authToken);

            return _httpClient.Execute<List<GetCharactersCompletedTasksResponse>>(request);
        }

        /// <summary>
        /// Return a list of opportunities groups
        /// </summary>
        /// <returns>A list of opportunities group ids</returns>
        public ESIResponse<List<int>> GetOpportunitiesGroups()
        {
            var request = RestRequestHelper.CreateGetRequest("opportunities/groups/");

            return _httpClient.Execute<List<int>>(request);
        }

        /// <summary>
        /// Return information of an opportunities group
        /// </summary>
        /// <param name="opportunityGroupId">ID of an opportunities group</param>
        /// <returns>Details of an opportunities group</returns>
        public ESIResponse<GetOpportunitiesGroupResponse> GetOpportunitiesGroup(int opportunityGroupId)
        {
            var request = RestRequestHelper.CreateGetRequest($"opportunities/groups/{opportunityGroupId}/");

            return _httpClient.Execute<GetOpportunitiesGroupResponse>(request);
        }

        /// <summary>
        /// Return a list of opportunities tasks
        /// </summary>
        /// <returns>A list of opportunities task ids</returns>
        public ESIResponse<List<int>> GetOpportunitiesTasks()
        {
            var request = RestRequestHelper.CreateGetRequest("opportunities/tasks/");

            return _httpClient.Execute<List<int>>(request);
        }

        /// <summary>
        /// Return information of an opportunities task
        /// </summary>
        /// <param name="taskId">ID of an opportunities task</param>
        /// <returns>Details of an opportunities task</returns>
        public ESIResponse<GetOpportunitiesTaskResponse> GetOpportunitiesTask(int taskId)
        {
            var request = RestRequestHelper.CreateGetRequest($"opportunities/tasks/{taskId}/");

            return _httpClient.Execute<GetOpportunitiesTaskResponse>(request);
        }
    }
}