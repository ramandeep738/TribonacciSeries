using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            IEnumerable<int> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(20, result.Count());
            Assert.AreEqual(3, result.ElementAt(3));
            Assert.AreEqual(9, result.ElementAt(5));

        }

        [TestMethod]
        public void TestTribonnicSeriesDivisiblePositionN(int division, int position)
        {
            // Arrange
            TribonnicController controller = new TribonnicController();

            // Act
            int result = controller.GetbyDivisionPosition(division,position);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(355, result);
            
        }
    }
}
