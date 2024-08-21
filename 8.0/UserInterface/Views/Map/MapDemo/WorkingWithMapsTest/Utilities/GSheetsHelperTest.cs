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

        [Fact]
        public void GSheetsHelperAddAndDeleteItemsTest()
        {
            string _spreadsheetId = "12SQY5ElDVm5uRaFJ6o5YcEV-fjyWB8BQQFn9xSh7A5I";
            string _range = "A2:Z100";

            GSheetsHelper gSheetsHelper = new GSheetsHelper("Credentials/handi-credentials.json", _spreadsheetId, _range);
            List<List<string>> items = gSheetsHelper.GetItems();
            int count = items.Count;

            // Add new item
            // Id	Name	CreationDate	Latitude	Longitude	Number	Paiement	Confirmed	Internal	ImageUrl
            String uniqueId = Guid.NewGuid().ToString();
            List<object> newItem = new List<object>(new object[] { uniqueId, "GSheetsHelperAddAndDeleteItemsTest", "2018-02-18 11:10:13Z", 0.1, 0.2, 1000, false, true, "https://test.jpg" });
            gSheetsHelper.AddItem(newItem);
            System.Threading.Thread.Sleep(10000);
            List<List<string>> items2 = gSheetsHelper.GetItems();
            int count2 = items2.Count;

            // Remove new item
            gSheetsHelper.RemoveItem(uniqueId);
            System.Threading.Thread.Sleep(10000);
            List<List<string>> items3 = gSheetsHelper.GetItems();
            int count3 = items3.Count;

            Assert.Equal(count + 1, count2);
            Assert.Equal(count, count3);
        }

    }
}
