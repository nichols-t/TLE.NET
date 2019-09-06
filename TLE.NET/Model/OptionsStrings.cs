using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLE.NET.Model
{
    /// <summary>
    /// Stores the query parameter strings recognized by the collection API. 
    /// </summary>
    public sealed class OptionsStrings
    {
        public static string Search = "search";
        public static string Prn = "prn";
        public static string Sort = "sort";
        public static string SortDir = "sort-dir";
        public static string Page = "page";
        public static string PageSize = "page-size";
    }
}
