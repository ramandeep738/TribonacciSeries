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
        public void TestTribonnicSeriesDivisiblePositionN(int Series,int division, int position)
        {
            // Arrange
            TribonnicController controller = new TribonnicController();
            ResponsMessage objrestult = new ResponsMessage();

            // Act
            objrestult = controller.GetSeriesValue(Series,division, position);

            // Assert
            Assert.IsNotNull(objrestult.Series);
            Assert.AreEqual(355, objrestult.Result);
            
        }
    }
}
