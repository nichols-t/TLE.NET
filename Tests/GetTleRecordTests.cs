using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TLE.NET;
using TLE.NET.Model;

namespace Tests
{
    /// <summary>
    /// Makes an API call for a single satellite records and ensures that the response has the correct information. 
    /// </summary>
    [TestClass]
    public class GetTleRecordTests
    {
        private TleApiClient client;
        private TleRecord actualRecord;

        // Constants asserted against. This is the list of "right answers"
        // that we expect for the call with this Id.
        private const int requestId = 11416;

        private const string expectedName = "NOAA 6 [P]";
        private const string expectedType = "TleModel";
        private readonly string expectedId = @"https://data.ivanstanojevic.me/api/tle/" + requestId;

        [TestInitialize]
        public void Initialize()
        {
            client = new TleApiClient();
            actualRecord = client.GetTleRecord(requestId);
        }

        [TestMethod]
        public void RecordNameIsCorrect()
        {
            Assert.AreEqual(expectedName, actualRecord.Name);
        }

        [TestMethod]
        public void SatelliteIdIsCorrect()
        {
            Assert.AreEqual(requestId, actualRecord.SatelliteId);
        }

        [TestMethod]
        public void TypeIsCorrect()
        {
            Assert.AreEqual(expectedType, actualRecord.Type);
        }

        [TestMethod]
        public void IdIsCorrect()
        {
            Assert.AreEqual(expectedId, actualRecord.Id);
        }

        [TestMethod]
        public void Line1IsNotEmpty()
        {
            Assert.IsFalse(String.IsNullOrWhiteSpace(actualRecord.Line1), "Record line1 should not be empty.");
        }

        [TestMethod]
        public void Line2IsNotEmpty()
        {
            Assert.IsFalse(String.IsNullOrWhiteSpace(actualRecord.Line2), "Record line2 should not be empty.");
        }
    }
}
