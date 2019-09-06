using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLE.NET;
using TLE.NET.Model;

namespace Tests
{
    /// <summary>
    /// Makes API calls for collections of TLE satellite records and checks to make sure that the 
    /// responses are correct.
    /// </summary>
    [TestClass]
    public class GetTleRecordCollectionTests
    {
        private TleApiClient client;
        private TleRecordCollection records;

        // Expected values. The "right answers" for the tests.
        private const int expectedDefaultPageSize = 20;
        private const string expectedId = @"https://data.ivanstanojevic.me/api/tle";
        private const string expectedType = "Collection";

        [TestInitialize]
        public void Initialize()
        {
            client = new TleApiClient();
            records = client.GetAllTleRecords();
        }

        [TestMethod]
        public void DefaultPageSizeIsCorrect()
        {
            Assert.AreEqual(expectedDefaultPageSize, records.Parameters.PageSize);
        }

        [TestMethod]
        public void PageSizeAndRecordsCountMatch()
        {
            Assert.AreEqual(records.Parameters.PageSize, records.Member.Count);
        }

        [TestMethod]
        public void IdIsCorrect()
        {
            Assert.AreEqual(expectedId, records.Id);
        }

        [TestMethod]
        public void TypeIsCorrect()
        {
            Assert.AreEqual(expectedType, records.Type);
        }

        [TestMethod]
        public void TotalItemsIsPositive()
        {
            Assert.IsTrue(records.TotalItems > 0, "Response returned no records.");
        }
    }
}
