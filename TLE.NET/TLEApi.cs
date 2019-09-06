using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLE.NET.Model;

namespace TLE.NET
{
    /// <summary>
    /// Proxy class to access the NASA TLE Api.
    /// </summary>
    public class TleApi
    {
        /// <summary>
        /// This is the base API URL that all calls to the NASA TLE Api should use.
        /// </summary>
        const string baseUrl = @"https://data.ivanstanojevic.me/api/tle";

        /// <summary>
        /// Restsharp client object. This object does the actual API access.
        /// </summary>
        readonly IRestClient client;

        /// <summary>
        /// Initializes the RestSharp Client.
        /// </summary>
        public TleApi()
        {
            client = new RestClient(baseUrl);
        }

        /// <summary>
        /// Sends a request and gets a response from the NASA TLE API 
        /// </summary>
        /// <typeparam name="T">The type of object the API is expected to return.</typeparam>
        /// <param name="request">The request object to send to the RestSharp API client.</param>
        /// <returns>The API response as an object of type T.</returns>
        /// <exception cref="ApplicationException">If the API returns an error response.</exception>
        private T Execute<T>(RestRequest request) where T: new()
        {
            request.RequestFormat = RestSharp.DataFormat.Json;

            IRestResponse<T> response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error response. Check inner exception for more details.";
                throw new ApplicationException(message, response.ErrorException);
            }

            return response.Data;
        }

        /// <summary>
        /// Returns the record of the satellite with the given Id. 
        /// </summary>
        /// <param name="satelliteId">The Id to search for.</param>
        /// <returns>A TleRecord if a satellite with that Id exists.</returns>
        public TleRecord GetTleRecord(int satelliteId)
        {
            var request = new RestRequest("/{Id}");
            request.AddParameter("Id", satelliteId, ParameterType.UrlSegment);

            return Execute<TleRecord>(request);
        }
        
        /// <summary>
        /// Returns a collection of TLE records with default pagination.
        /// </summary>
        /// <param name="options">The query parameters for the collection request.</param>
        /// <returns>A TleRecordCollection.</returns>
        public TleRecordCollection GetAllTleRecords(TleRecordCollectionOptions options)
        {
            var request = CreateRequest(options);

            return Execute<TleRecordCollection>(request);
        }

        /// <summary>
        /// Initializes the request object with the given query options. This is only used for 
        /// the collection API, because the record API only takes one mandatory id parameter. 
        /// </summary>
        /// <param name="options">The query parameters object.</param>
        /// <returns>A RestRequest with all the query parameters set.</returns>
        private RestRequest CreateRequest(TleRecordCollectionOptions options)
        {
            // We allow the options object to be null, because the user may want to not set any
            // additional options 

            var request = new RestRequest();
            
            // Set all possible options
            if (options?.Search != null)
            {
                request.AddQueryParameter(OptionsStrings.Search, options.Search);
            }

            if (options?.Prn != null)
            {
                request.AddQueryParameter(OptionsStrings.Prn, options.Prn.ToString());
            }

            if (options?.Sort != null)
            {
                request.AddQueryParameter(OptionsStrings.Sort, options.Sort.ToString());
            }

            if (options?.SortDir != null)
            {
                request.AddQueryParameter(OptionsStrings.SortDir, options.SortDir);
            }

            if (options?.Page != null)
            {
                request.AddQueryParameter(OptionsStrings.Page, options.Page.ToString());
            }

            if (options?.PageSize != null)
            {
                request.AddQueryParameter(OptionsStrings.PageSize, options.PageSize.ToString());
            }

            return request;
        }
    }
}
