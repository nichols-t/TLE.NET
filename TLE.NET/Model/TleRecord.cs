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
        /// <summary>
        /// The URI of this record.
        /// </summary>
        [DeserializeAs(Name = "@id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of this record.
        /// </summary>
        [DeserializeAs(Name = "@type")]
        public string Type { get; set; }

        /// <summary>
        /// The Id number of this record.
        /// </summary>
        [DeserializeAs(Name = "satelliteId")]
        public int SatelliteId { get; set; }

        /// <summary>
        /// The human-readable name of this record.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The date of the request that generated this record.
        /// </summary>
        [DeserializeAs(Name = "date")]
        public string Date { get; set; }

        /// <summary>
        /// The first line of this record's TLE coordinates.
        /// </summary>
        [DeserializeAs(Name = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of this record's TLE coordinates.
        /// </summary>
        [DeserializeAs(Name = "line2")]
        public string Line2 { get; set; }
    }
}
