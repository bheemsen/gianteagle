using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.Utilities
{
    public static class DateExtension
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromUnixTime(this DateTime date, long epoch)
        {
            return date.AddSeconds(epoch);
        }

    }
}
