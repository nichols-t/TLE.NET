using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLE.NET;
using TLE.NET.Model;

namespace Test
{
    /// <summary>
    /// Provides a simple demonstration of TLE.NET usage. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new API object
            var tleApi = new TleApiClient();
            var mir = tleApi.GetTleRecord(11416);
            Console.WriteLine(mir.Name);

            var tleAllOptions = new TleRecordCollectionOptions
            {
                // Show 100 results per page
                PageSize = 100,
                // Search for "ISS" in the name
                Search = "ISS"
            };

            TleRecordCollection all = tleApi.GetAllTleRecords(tleAllOptions);
       
            // Number of results returned
            Console.WriteLine(all.Member.Count);

            // The name of the fifth result, which last I checked was the ZARYA module of the ISS
            Console.WriteLine(all.Member[4].Name);
        }
    }
}
