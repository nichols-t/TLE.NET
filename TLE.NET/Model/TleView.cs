using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE.NET.Model
{
    /// <summary>
    /// Represents the View object returned by the TLE Collection API. 
    /// </summary>
    public class TleView
    {
        /// <summary>
        /// The view Id. This is just the request string from which the current results were obtained. 
        /// </summary>
        [DeserializeAs(Name = "@id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of this object according to the API response. 
        /// </summary>
        [DeserializeAs(Name ="@type")]
        public string Type { get; set; }

        /// <summary>
        /// The URI for the first page of results. 
        /// </summary>
        [DeserializeAs(Name = "first")]
        public string First { get; set; }

        /// <summary>
        /// The URI for the previous page of results. Null if no previous page exists.
        /// </summary>
        [DeserializeAs(Name = "previous")]
        public string Previous { get; set; }

        /// <summary>
        /// The URI for the next page of results. Null if no next page exists. 
        /// </summary>
        [DeserializeAs(Name = "next")]
        public string Next { get; set; }

        /// <summary>
        /// The URI for the last page of results. 
        /// </summary>
        [DeserializeAs(Name = "last")]
        public string Last { get; set; }
    }
}
