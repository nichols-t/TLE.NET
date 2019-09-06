using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE.NET.Model
{
    /// <summary>
    /// Represents a single TLE Satellite record.
    /// </summary>
    public class TleRecord
    {
        #region JSON Key Strings
        private const string idKey = "@id";
        private const string typeKey = "@type";
        private const string satelliteIdKey = "satelliteId";
        private const string nameKey = "name";
        private const string dateKey = "date";
        private const string line1Key = "line1";
        private const string line2Key = "line2";
        #endregion

        #region Properties
        /// <summary>
        /// The URI of this record.
        /// </summary>
        [DeserializeAs(Name = idKey)]
        public string Id { get; set; }

        /// <summary>
        /// The type of this record.
        /// </summary>
        [DeserializeAs(Name = typeKey)]
        public string Type { get; set; }

        /// <summary>
        /// The Id number of this record.
        /// </summary>
        [DeserializeAs(Name = satelliteIdKey)]
        public int SatelliteId { get; set; }

        /// <summary>
        /// The human-readable name of this record.
        /// </summary>
        [DeserializeAs(Name = nameKey)]
        public string Name { get; set; }

        /// <summary>
        /// The date of the request that generated this record.
        /// </summary>
        [DeserializeAs(Name = dateKey)]
        public string Date { get; set; }

        /// <summary>
        /// The first line of this record's TLE coordinates.
        /// </summary>
        [DeserializeAs(Name = line1Key)]
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of this record's TLE coordinates.
        /// </summary>
        [DeserializeAs(Name = line2Key)]
        public string Line2 { get; set; }
        #endregion
    }
}