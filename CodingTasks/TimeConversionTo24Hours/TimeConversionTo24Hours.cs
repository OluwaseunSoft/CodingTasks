using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.TimeConversionTo24Hours
{
    public static class TimeConversionTo24Hours
    {
        public static string TimeConversion(string time)
        {
            var d = DateTime.Parse(time);

            return d.ToString("HH:mm:ss");
        }
    }
}
