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
        /// <summary>
        /// Not sure what this is, seems to be a general schema for the JSON response.
        /// </summary>
        [DeserializeAs(Name = "@context")]
        public string Context { get; set; }

        /// <summary>
        /// The URI of the request that generated this response.
        /// </summary>
        [DeserializeAs(Name = "@id")]
        public string Id { get; set; }

        /// <summary>
        /// The Type of this response.
        /// </summary>
        [DeserializeAs(Name = "@type")]
        public string Type { get; set; }

        /// <summary>
        /// The total number of items in the collection. 
        /// </summary>
        [DeserializeAs(Name = "totalItems")]
        public int TotalItems { get; set; }

        /// <summary>
        /// The TleRecords in this collection.
        /// </summary>
        [DeserializeAs(Name = "member")]
        public List<TleRecord> Member { get; set; }

        /// <summary>
        /// A TleView object that handles paginating the response data.
        /// </summary>
        [DeserializeAs(Name = "view")]
        public TleView View { get; set; }
    }
}
