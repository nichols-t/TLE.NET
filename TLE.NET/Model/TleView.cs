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
        #region JSON Key Strings
        private const string idKey = "@id";
        private const string typeKey = "@type";
        private const string firstKey = "first";
        private const string previousKey = "previous";
        private const string nextKey = "next";
        private const string lastKey = "next";
        #endregion

        #region Properties
        /// <summary>
        /// The view Id. This is just the request string from which the current results were obtained. 
        /// </summary>
        [DeserializeAs(Name = idKey)]
        public string Id { get; set; }

        /// <summary>
        /// The type of this object according to the API response. 
        /// </summary>
        [DeserializeAs(Name =typeKey)]
        public string Type { get; set; }

        /// <summary>
        /// The URI for the first page of results. 
        /// </summary>
        [DeserializeAs(Name = firstKey)]
        public string First { get; set; }

        /// <summary>
        /// The URI for the previous page of results. Null if no previous page exists.
        /// </summary>
        [DeserializeAs(Name = previousKey)]
        public string Previous { get; set; }

        /// <summary>
        /// The URI for the next page of results. Null if no next page exists. 
        /// </summary>
        [DeserializeAs(Name = nextKey)]
        public string Next { get; set; }

        /// <summary>
        /// The URI for the last page of results. 
        /// </summary>
        [DeserializeAs(Name = lastKey)]
        public string Last { get; set; }
        #endregion
    }
}