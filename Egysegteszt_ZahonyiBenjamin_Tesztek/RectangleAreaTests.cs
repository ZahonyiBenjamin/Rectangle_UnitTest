using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Egysegteszt_ZahonyiBenjamin;

namespace Egysegteszt_ZahonyiBenjamin_Tesztek
{
    [TestClass]
    public class RectangleAreaTests
    {
        [TestMethod]
        public void CalculateArea_ReturnCorrectArea_ForPosNumbers()
        {
            //Arrange
            double width = 5;
            double height = 10;
            double expected = 50;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void CalculateArea_ReturnZero_ForZeroWidth()
        {
            //Arrange
            double width = 0;
            double height = 10;
            double expected = 0;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void CalculateArea_ReturnZero_ForZeroHeight()
        {
            //Arrange
            double width = 10;
            double height = 0;
            double expected = 0;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(expected, area);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateArea_ThrowException_ForNegWidth()
        {
            //Arrange
            double width = -5;
            double height = 10;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert
            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateArea_ThrowException_ForNegHeight()
        {
            //Arrange
            double width = 10;
            double height = -5;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert

        }

        [TestMethod]
        public void CalculateArea_ReturnCorrectArea_ForBigNumbers()
        {
            //Arrange
            double width = 1000000;
            double height = 2000000;
            double expected = 2000000000000;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void CalculateArea_ReturnCorrectArea_ForNotIntNumbers()
        {
            //Arrange
            double width = 4.5;
            double height = 8.2;
            double expected = 36.9;
            var calculator = new Rectangle();

            //Act
            double area = calculator.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(expected, area);
        }
    }
}
