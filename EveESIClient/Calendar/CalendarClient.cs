using EveESIClient.Client;
using EveESIClient.Helpers;
using EveESIClient.Models.Calendar;
using RestSharp;
using System;
using System.Collections.Generic;

namespace EveESIClient.Calendar
{
    public class CalendarClient
    {
        private readonly IHttpClient _client;
        internal CalendarClient(IHttpClient httpClient)
        {
            _client = httpClient;
        }

        /// <summary>
        /// Get 50 event summaries from the calendar. If no from_event ID is given, 
        /// the resource will return the next 50 chronological event summaries from now. 
        /// If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event.
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fromEvent">The event ID to retrieve events from</param>
        /// <returns>A collection of event summaries</returns>
        public ESIResponse<List<GetCharacterCalendarResponse>> GetCharacterCalendar(string authToken, Int64 characterId, Int64? fromEvent)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/calendar/", Method.GET,
                    authToken);

            request.AddParameter("fromEvent", fromEvent, ParameterType.QueryString);

            return _client.Execute<List<GetCharacterCalendarResponse>>(request);
        }

        /// <summary>
        /// Get all the information for a specific event
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <returns>Full details of a specific event</returns>
        public ESIResponse<GetEventResponse> GetEvent(string authToken, Int64 characterId, Int64 eventId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/calendar/{eventId}/", Method.GET,
                    authToken);

            return _client.Execute<GetEventResponse>(request);
        }

        /// <summary>
        /// Set your response status to an event
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <param name="response">The response value to set, overriding current value. Candidates are: [ accepted, declined, tentative ]</param>
        /// <returns>IsSuccessful will be true on successfull call.</returns>
        public ESIResponse<object> RespondEvent(string authToken, Int64 characterId, Int64 eventId, string response)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/calendar/{eventId}/", Method.PUT,
                    authToken);

            return _client.Execute<object>(request);
        }

        /// <summary>
        /// Get all invited attendees for a given event
        /// </summary>
        /// <param name="authToken">Access token to use</param>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <returns>List of attendees</returns>
        public ESIResponse<List<GetEventAttendeesResponse>> GetEventAttendees(string authToken, Int64 characterId, Int64 eventId)
        {
            var request = RestRequestHelper.CreateAuthrorizedRestRequest($"characters/{characterId}/calendar/{eventId}/attendees/", Method.GET,
                    authToken);

            return _client.Execute<List<GetEventAttendeesResponse>>(request);
        }
    }
}
