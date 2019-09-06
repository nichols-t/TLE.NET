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
        public static readonly string Search = "search";
        public static readonly string Prn = "prn";
        public static readonly string Sort = "sort";
        public static readonly string SortDir = "sort-dir";
        public static readonly string Page = "page";
        public static readonly string PageSize = "page-size";
    }
}
