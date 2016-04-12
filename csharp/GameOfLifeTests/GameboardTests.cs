using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class GameboardTests
    {
        [TestMethod]
        public void GameboardIsNotNull()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act

            // Assert
            Assert.IsNotNull(gameboard);
        }
        [TestMethod]
        public void GameboardHasCells()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act
            var actual = gameboard.actualStatusGrid[2, 2];
            var statusValue = actual.status;
            var expected = false;

            // Assert
            Assert.AreEqual(statusValue, expected);
        }
    }
}
