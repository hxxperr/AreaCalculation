using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Tests
{
    [TestClass()]
    public class CircleAreaCalcTests
    {
        [TestMethod()]
        public void CalcCircleArea_rad_3point5_11returned()
        {
            //arrange
            double radius = 3.5;
            double expected = 11;

            //act
            CircleAreaCalc areaCalc = new();
            double actual = areaCalc.AreaCalc(radius);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalcCircleArea_rad_5point2_16returnedFalse()
        {
            //arrange
            double radius = 5.2;
            double expected = 16;

            //act
            CircleAreaCalc areaCalc = new();
            double actual = areaCalc.AreaCalc(radius);

            //assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}