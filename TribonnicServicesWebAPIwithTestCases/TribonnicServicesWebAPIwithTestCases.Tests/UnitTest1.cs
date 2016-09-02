using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TribonnicServicesWebAPIwithTestCases.Controllers;
using TribonnicServicesWebAPIwithTestCases.Models;
namespace TribonnicServicesWebAPIwithTestCases.Tests
{
    [TestClass]
    [TestFixture]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
      
        [TestCase(20,5,3)]
      
        [TestMethod]
        public async void TestTribonnicSeriesDivisiblePositionN(int Series, int division, int position)
        {
            // Arrange
          //  int Series=20; int division=5; int position=3;
            TribonnicController controller = new TribonnicController();
            ResponsMessage objrestult = new ResponsMessage();

            // Act
            objrestult = controller.GetSeriesValue(Series, division, position);

            // Assert
            NUnit.Framework.Assert.IsNotNull(objrestult.Series);
            NUnit.Framework.Assert.AreEqual(355, objrestult.Result);

        }
    }
}
