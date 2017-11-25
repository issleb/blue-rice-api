using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlueRice.Api.Common.Models;
using Moq;
using NUnit.Framework;

namespace BlueRice.Api.Data.Tests
{
    public class StripDataTests
    {
        [Test]
        public void GetTest()
        {
            var data = new StripData();

            var strip = data.GetStrip(1);
            Assert.IsNotNull(strip);
        }
    }
}
