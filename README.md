# TLE.NET
A C# client for NASA's TLE Satellite API created using RestSharp.

## Usage

```C#
var client = new TleApiClient();

// Get a single record with satellite id 11416.
TleRecord oneRecord = client.GetTleRecord(11416);

// Get a list of records. This request is the default collection response.
TleRecordCollection all = client.GetAllTleRecords();

// Get a list of records with certain query parameters.
var options = new TleRecordCollectionOptions()
{
  // Search for "ISS" in the Name field of the records
  Search = "ISS",
  // How many records an individual response will return
  PageSize = 100,
  // Sort by Id, instead of the the default Name
  Sort = "id"
};

TleRecordCollection search = client.GetAllTleRecords(options);
```

Further documentation for the client is available in the TLE.NET class files. 
Documentation for the TLE API is available at [https://data.ivanstanojevic.me/api/tle/docs](https://data.ivanstanojevic.me/api/tle/docs).
