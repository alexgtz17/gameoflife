using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void CellInstantiation()
        {
            // Arrange
            Cell cell = new Cell();

            // Act

            // Assert
            Assert.IsNotNull(cell);
        }
        [TestMethod]
        public void CellInitStatusIsFalse()
        {
            // Arrange
            Cell cell = new Cell();

            // Act
            var expected = false;
            var actual = cell.status;

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CellChangeStatusToAlive()
        {
            // Arrange
            Cell cell = new Cell();

            // Act
            var expected = true;
            cell.status = true;
            var actual = cell.status;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
