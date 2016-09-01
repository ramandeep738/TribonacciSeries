using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TribonnicServicesWebAPIwithTestCases.Controllers;
using TribonnicServicesWebAPIwithTestCases.Models;
namespace TribonnicServicesWebAPIwithTestCases.Tests.Controllers
{
    [TestClass]
    public class TribonnicControllTest
    {
        [TestMethod]
        public void TestTribonnicSeries()
        {
            // Arrange
            TribonnicController controller = new TribonnicController();

            // Act

            ResponsMessage objrestult = new ResponsMessage();
            objrestult = controller.Get();

            // Assert
            Assert.IsNotNull(objrestult.Series);
            Assert.AreEqual(20, objrestult.Series.Count());
            Assert.AreEqual(3, objrestult.Series.ElementAt(3));
            Assert.AreEqual(9, objrestult.Series.ElementAt(5));

        }

        [TestMethod]
        public void TestTribonnicSeriesDivisiblePositionN(int division, int position)
        {
            // Arrange
            TribonnicController controller = new TribonnicController();
            ResponsMessage objrestult = new ResponsMessage();

            // Act
            objrestult = controller.GetSeriesValue(division, position);

            // Assert
            Assert.IsNotNull(objrestult.Series);
            Assert.AreEqual(355, objrestult.Result);
            
        }
    }
}
