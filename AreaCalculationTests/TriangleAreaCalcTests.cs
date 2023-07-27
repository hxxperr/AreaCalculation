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
    public class TriangleAreaCalcTests
    {
        [TestMethod()]
        public void CalcTriangleArea_sides_5_5_5_10point83returned()
        {
            //arrange
            double firstSide = 5;
            double secondSide = 5;
            double thirdSide = 6;
            double expected = 12;

            //act
            TriangleAreaCalc areaCalc = new();
            double actual = areaCalc.AreaCalc(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalcTriangleArea_sides_2_3_4_97returnedFalse()
        {
            //arrange
            double firstSide = 2;
            double secondSide = 3;
            double thirdSide = 4;
            double expected = 97;

            //act
            TriangleAreaCalc areaCalc = new();
            double actual = areaCalc.AreaCalc(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}