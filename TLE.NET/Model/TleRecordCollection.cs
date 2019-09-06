using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE.NET.Model
{
    /// <summary>
    /// Represents a collection of TleRecords. This class is used instead of a C# Collection class 
    /// because the API returns additional data besides the list of TleRecords. 
    /// </summary>
    public class TleRecordCollection
    {
        #region JSON Key Strings
        private const string contextKey = "@context";
        private const string idKey = "@id";
        private const string typeKey = "@type";
        private const string totalItemsKey = "totalItems";
        private const string memberKey = "member";
        private const string parametersKey = "parameters";
        private const string viewKey = "view";
        #endregion

        #region Properties
        /// <summary>
        /// Not sure what this is, seems to be a general schema for the JSON response.
        /// </summary>
        [DeserializeAs(Name = contextKey)]
        public string Context { get; set; }

        /// <summary>
        /// The URI of the request that generated this response.
        /// </summary>
        [DeserializeAs(Name = idKey)]
        public string Id { get; set; }

        /// <summary>
        /// The Type of this response.
        /// </summary>
        [DeserializeAs(Name = typeKey)]
        public string Type { get; set; }

        /// <summary>
        /// The total number of items in the collection. 
        /// </summary>
        [DeserializeAs(Name = totalItemsKey)]
        public int TotalItems { get; set; }

        /// <summary>
        /// The TleRecords in this collection.
        /// </summary>
        [DeserializeAs(Name = memberKey)]
        public List<TleRecord> Member { get; set; }

        /// <summary>
        /// The query parameters that were used in the request that returned this response.
        /// </summary>
        [DeserializeAs(Name = parametersKey)]
        public TleRecordCollectionOptions Parameters { get; set; }

        /// <summary>
        /// A TleView object that handles paginating the response data.
        /// </summary>
        [DeserializeAs(Name = viewKey)]
        public TleView View { get; set; }
        #endregion
    }
}