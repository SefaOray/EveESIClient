using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace EveESIClient.Mail
{
    public class MailClient
    {
        private readonly IHttpClient _httpClient;
        internal MailClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Return the 50 most recent mail headers belonging to the character that match the query criteria. 
        /// Queries can be filtered by label, and last_mail_id can be used to paginate backwards
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="labels">Fetch only mails that match one or more of the given labels</param>
        /// <param name="lastMailId">List only mail with an ID lower than the given ID, if present</param>
        /// <returns>The requested mail</returns>
        public ESIResponse<List<GetMailHeadersResponse>> GetMailHeaders(string authToken, int characterId, List<Int64> labels, int? lastMailId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/mail/", authToken);
            request.AddParameter("labels", labels, RestSharp.ParameterType.QueryString);
            request.AddParameter("last_mail_id", lastMailId, RestSharp.ParameterType.QueryString);

            return _httpClient.Execute<List<GetMailHeadersResponse>>(request);
        }

        /// <summary>
        /// Create and send a new mail
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailInput">The mail to send</param>
        /// <returns>Mail ID</returns>
        public ESIResponse<int> SendMail(string authToken, int characterId, SendMailInput mailInput)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/mail/", authToken);
            request.AddJsonBody(mailInput);

            return _httpClient.Execute<int>(request);
        }

        /// <summary>
        /// Delete a mail
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <returns>Mail deleted</returns>
        public ESIResponse<object> DeleteMail(string authToken, int characterId, int mailId)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/mail/{mailId}/", authToken);

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Return the contents of an EVE mail
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <returns>Contents of a mail</returns>
        public ESIResponse<GetMailResponse> GetMail(string authToken, int characterId, int mailId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/mail/{mailId}/", authToken);

            return _httpClient.Execute<GetMailResponse>(request);
        }

        /// <summary>
        /// Update metadata about a mail
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="mailId">An EVE mail ID</param>
        /// <param name="read">Whether the mail is flagged as read</param>
        /// <param name="labels">Labels to assign to the mail. Pre-existing labels are unassigned</param>
        /// <returns>Mail updated</returns>
        public ESIResponse<object> UpdateMail(string authToken, int characterId, int mailId, bool? read, List<long> labels)
        {
            var request = RestRequestHelper.CreateAuthorizedPutRequest($"characters/{characterId}/mail/{mailId}/", authToken);
            request.AddJsonBody(new { read, labels });

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Return a list of the users mail labels, unread counts for each label and a total unread count
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>A list of mail labels and unread counts</returns>
        public ESIResponse<GetMailsAndUnreadCountsResponse> GetMailsAndUnreadCounts(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/mail/labels/", authToken);

            return _httpClient.Execute<GetMailsAndUnreadCountsResponse>(request);
        }

        /// <summary>
        /// Create a mail label
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="name">Name for new label</param>
        /// <param name="color">Hexadecimal string representing label color, in RGB format</param>
        /// <returns>Label created</returns>
        public ESIResponse<long> CreateLabel(string authToken, int characterId, string name, string color)
        {
            var request = RestRequestHelper.CreateAuthorizedPostRequest($"characters/{characterId}/mail/labels/", authToken);
            request.AddJsonBody(new { name, color });

            return _httpClient.Execute<long>(request);
        }

        /// <summary>
        /// Delete a mail label
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="labelId">An EVE label id</param>
        /// <returns>Label deleted</returns>
        public ESIResponse<object> DeleteLabel(string authToken, int characterId, long labelId)
        {
            var request = RestRequestHelper.CreateAuthorizedDeleteRequest($"characters/{characterId}/mail/labels/{labelId}/", authToken);

            return _httpClient.Execute<object>(request);
        }

        /// <summary>
        /// Return all mailing lists that the character is subscribed to
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <returns>Mailing lists</returns>
        public ESIResponse<List<GetMailingListSubscriptionsResponse>> GetMailingListSubscriptions(string authToken, int characterId)
        {
            var request = RestRequestHelper.CreateAuthorizedGetRequest($"characters/{characterId}/mail/labels/lists/", authToken);

            return _httpClient.Execute<List<GetMailingListSubscriptionsResponse>>(request);
        }
    }
}
