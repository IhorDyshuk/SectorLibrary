using Microsoft.VisualStudio.TestTools.UnitTesting;
using SectorLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class SectorTests
    {
        [TestMethod()]
        public void SectorTest_DefaultValues_ReturnCorrectValues()
        {
            // Arrange & Act
            Sector c = new Sector();

            // Assert
            Assert.AreEqual(0, c.Angle, "Default angle should be zero");
            Assert.AreEqual(0, c.Radius, "Default radius should be zero");
        }

        [TestMethod()]
        public void SectorTest_ParametrValues_ReturnCorrectValues()
        {
            // Arrange & Act
            Sector c = new Sector(1, 1);

            // Assert
            Assert.AreEqual(1, c.Angle, "Incorrect work of the constructor with parameters");
            Assert.AreEqual(1, c.Radius, "Incorrect work of the constructor with parameters");
        }

        [TestMethod()]
        public void SectorTest_NegativeAllValues_ReturnExeption()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Sector(-1, -1));
        }

        [TestMethod()]
        public void SectorTest_NegativeRadius_ReturnExeption()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Sector(-1, 1));
        }

        [TestMethod()]
        public void SectorTest_NegativeAngle_ReturnExeption()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Sector(1, -1));
        }

        [TestMethod()]
        public void SectorTest_AngleBiggerThan360_ReturnExeption()
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Sector(1, 361));
        }

        [TestMethod()]
        public void AddTest_TwoSectors_ReturnSector()
        {
            // Arrange
            Sector c1 = new Sector(1, 1);
            Sector c2 = new Sector(1, 1);
            Sector expected = new Sector(2, 2);

            // Act
            ISector actual = c1 + c2;
            
            // Assert
            Assert.AreEqual(expected, actual, "Icorrect work of the operator \"+\"");
        }

        [TestMethod()]
        public void SubtTest_TwoSectors_ReturnSector()
        {
            // Arrange
            Sector c1 = new Sector(2, 2);
            Sector c2 = new Sector(1, 1);
            Sector expected = new Sector(1, 1);

            // Act
            ISector actual = c1 - c2;

            // Assert
            Assert.AreEqual(expected, actual, "Icorrect work of the operator \"-\"");
        }

        [TestMethod()]
        public void EqualTest_EqualTwoSectors_ReturnBool()
        {
            // Arrange
            Sector c1 = new Sector(1,1);
            Sector c2 = new Sector(1,1);
            bool expected = true;

            // Act
            bool actual = c1 == c2;

            // Assert
            Assert.AreEqual(expected, actual, "Icorrect work of the operator \"==\"");
        }

        [TestMethod()]
        public void NonEqualTest_EqualTwoSectors_ReturnBool()
        {
            // Arrange
            Sector c1 = new Sector(2, 1);
            Sector c2 = new Sector(1, 1);
            bool expected = true;

            // Act
            bool actual = c1 != c2;

            // Assert
            Assert.AreEqual(expected, actual, "Icorrect work of the operator \"!=\"");
        }

        [TestMethod()]
        public void ImplictTest_ConvertToDouble_ReturnAngle()
        {
            // Arrange
            Sector c = new Sector(1, 1);
            double expected = 1;

            // Act 
            double actual = c.Angle;

            // Assert
            Assert.AreEqual(expected, actual, "Incorrect function for conversion");
        }

        [TestMethod()]
        public void ExplictTest_ConvertToDouble_ReturnAngle()
        {
            // Arrange
            Sector c = new Sector(1, 1);
            double expected = 1;

            // Act 
            double actual = (double)c;

            // Assert
            Assert.AreEqual(expected, actual, "Incorrect function for conversion");
        }

        [TestMethod()]
        public void TrueTest_CorrectValues_ReturnTrue()
        {
            // Arrange
            Sector c = new Sector(100, 100);
            
            // Act
            bool result = c ? true: false;

            //Assert
            Assert.IsTrue(result, "Incorrect function for comparisons");
        }

        [TestMethod()]
        public void EqualsTest_TwoObjects_ReturnsTrue()
        {
            // Arrange
            Sector c1 = new Sector(1, 1);
            Sector c2 = new Sector(1, 1);

            // Act & Assert
            Assert.AreEqual(c1, c2, "Incorrect function for comparisons");
        }

        [TestMethod()]
        public void GetHashCodeTest_TwoObjects_ReturnsTrue()
        {
            // Arrange
            Sector c1 = new Sector(1, 1);
            Sector c2 = new Sector(1, 1);

            // Act
            int hash1 = c1.GetHashCode();
            int hash2 = c2.GetHashCode();

            // Assert
            Assert.AreEqual(hash1, hash2, "Incorrect function for comparisons");
        }

        [TestMethod()]
        public void ToStringTest_ValidValues_ReturnCorrectConvertation()
        {
            // Arrange
            Sector c = new Sector(1, 1);
            string exeption = "Sector wtih Angle: 1° and Radius: 1";

            // Act
            string actual = c.ToString();

            // Assert
            Assert.AreEqual(exeption, actual, "Wrong ToString function");

        }
    }
}