using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Common
{
    class Common
    {
        private static Common _Instance;

        public static Common Instance
        {

            get
            {
                if (_Instance == null)
                {
                    _Instance = new Common();
                }
                return (_Instance);
            }
        }

        public List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();
            }
            return data_sorted;
        }

        public object GetDynamicSortProperty(object item, string propName)
        {
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }

        public DateTime FromUnixTime(long unixTime)
        {
            unixTime = unixTime / 1000000;
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
        public DateTime UnixTime(long unixTimeStamp)
        {
            DateTime localDateTimeOffset;
            try
            {
                localDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimeStamp).DateTime.ToLocalTime();
            }
            catch
            {
                localDateTimeOffset = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            }
            return localDateTimeOffset;
        }
        public bool IsDigitOrLetterOrSymbolOrSpace(char ch)
        {
            return Char.IsLetterOrDigit(ch) || Char.IsSymbol(ch) || Char.IsWhiteSpace(ch);
        }
    }
}
