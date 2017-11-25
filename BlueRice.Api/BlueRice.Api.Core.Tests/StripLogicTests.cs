using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BlueRice.Api.Common.Models;
using BlueRice.Api.Data;
using Moq;
using NUnit.Framework;

namespace BlueRice.Api.Core.Tests
{
    public class StripLogicTests
    {
        [Test]
        public void GetTest()
        {
            var data = new Strip()
            {
                Id = 1,
                Number = 2,
                Description = "my description"
            };

            var stripDataMock = new Mock<IStripData>();
            stripDataMock.Setup(x => x.GetStrip(It.IsAny<int>())).Returns(data);

            var logic = new StripLogic(stripDataMock.Object);

            var strip = logic.GetStrip(1);

            Assert.IsNotNull(strip);
            Assert.AreEqual(data.Id, strip.Id);
            Assert.AreEqual(data.Number, strip.Number);
            Assert.AreEqual(data.Description, strip.Description);
        }
    }
}
