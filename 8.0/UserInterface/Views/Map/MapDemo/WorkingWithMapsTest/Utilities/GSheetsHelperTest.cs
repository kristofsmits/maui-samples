using System.Reflection;
using WorkingWithMapsLib.Utilities;
using Xunit;

namespace WorkingWithMapsTest.Utilities
{
    public class GSheetsHelperTest
    {
        [Fact]
        public void GSheetsHelperGetItemsTest()
        {
            int a = 1 + 2;
            Assert.Equal(3, a);

            string _spreadsheetId = "12SQY5ElDVm5uRaFJ6o5YcEV-fjyWB8BQQFn9xSh7A5I";
            string _range = "A2:Z100";

            GSheetsHelper g = new GSheetsHelper("Credentials/handi-credentials.json", _spreadsheetId, _range);
            List<List<string>> items = g.GetItems();

            foreach (List<string> item in items)
            {
                foreach (string s in item)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
