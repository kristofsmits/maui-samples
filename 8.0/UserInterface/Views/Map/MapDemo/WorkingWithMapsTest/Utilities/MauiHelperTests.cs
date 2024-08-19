using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Maui.Devices.Sensors;

namespace WorkingWithMapsTest.Utilities
{
    public class MauiHelperTests
    {
        [Fact]
        public void GetLocationTest()
        {
            MauiHelper mauiHelper = new MauiHelper();
            Location l = mauiHelper.GetCurrentLocation();
            // location is null on windows
            Assert.Null(l);
        }
    }
}
