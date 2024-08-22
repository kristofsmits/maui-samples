using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMapsLib.Utilities
{
    public class ConversionHelper
    {
        // parse any double, whether comma or point is used as decimal separator
        // https://stackoverflow.com/questions/11560465/parse-strings-to-double-with-comma-and-point
        public static double parseToDouble(string text)
        {
            text = text.Replace(',', '.');
            return double.Parse(text, NumberStyles.Any, CultureInfo.InvariantCulture);
        }
    }
}
