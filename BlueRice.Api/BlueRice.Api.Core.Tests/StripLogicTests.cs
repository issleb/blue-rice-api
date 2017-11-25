using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BlueRice.Api.Common.Models;
using BlueRice.Api.Core.Logic;
using Moq;
using NUnit.Framework;

namespace BlueRice.Api.Core.Tests
{
    public class StripLogicTests
    {
        [Test]
        public void GetTest() {
            var logic = new StripLogic();

            var strip = logic.GetStrip(1);

            Assert.IsNotNull(strip);
            Assert.AreEqual(1, strip.Id);
        }
    }
}
