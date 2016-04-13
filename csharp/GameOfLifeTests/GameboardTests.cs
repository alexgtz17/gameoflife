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
            var statusValue = gameboard.actualStatusGrid[2, 2];
            var actual = statusValue.status;
            var expected = false;

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GameboardCellCanBeTrue()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act
            gameboard.actualStatusGrid[0, 0].status = true;
            var actual = gameboard.actualStatusGrid[0, 0].status;
            var expected = true;

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GameboardCheckForNeighbors()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act
            gameboard.actualStatusGrid[2, 2].status = true;
            gameboard.actualStatusGrid[2, 3].status = true;
            gameboard.actualStatusGrid[2, 4].status = true;
            gameboard.checkNeighbors();
            var actual = gameboard.actualStatusGrid[3, 3].neighbors;
            var expected = 3;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
