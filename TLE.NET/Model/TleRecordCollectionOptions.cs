using RestSharp.Serializers;

namespace TLE.NET.Model
{
    /// <summary>
    /// Represents the different query parameters that can be passed to the API when requesting a collection of TLE objects. 
    /// </summary>
    public class TleRecordCollectionOptions
    {
        /// <summary>
        /// The string that the request will ask the API to search for. Default is "".
        /// </summary>
        [SerializeAs(Name = "search")]
        public string Search { get; set; }
        /// <summary>
        /// "Filter by pseudo-random noise" according to documentation. Not sure what this actually does. 
        /// Default is null.
        /// </summary>
        [SerializeAs(Name = "prn")]
        public double? Prn { get; set; }
        /// <summary>
        /// Sorts by Id or Name. Default is Name. 
        /// </summary>
        [SerializeAs(Name = "sort")]
        public string Sort { get; set; }
        /// <summary>
        /// Determines the direction to sort in. Default is ascending.
        /// </summary>
        [SerializeAs(Name = "sort-dir")]
        public string SortDir { get; set; }
        /// <summary>
        /// The page of results currently in the API response. Default is 1. 
        /// </summary>
        [SerializeAs(Name = "page")]
        public int? Page { get; set; }
        /// <summary>
        /// The number of records to return on a page. Default is 20. 
        /// </summary>
        [SerializeAs(Name = "page-size")]
        public int PageSize { get; set; }
    }
}
