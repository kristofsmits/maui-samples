using System.Globalization;

namespace BlueSpot.Utilities
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
