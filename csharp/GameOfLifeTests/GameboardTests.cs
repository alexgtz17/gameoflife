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
        [TestMethod]
        public void GameboardCreateNextGridHalfBlinker()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act
            gameboard.actualStatusGrid[2, 2].status = true;
            gameboard.actualStatusGrid[2, 3].status = true;
            gameboard.actualStatusGrid[2, 4].status = true;
            gameboard.checkNeighbors();
            gameboard.nextGen();
            var actual_one = gameboard.actualStatusGrid[1, 3].status;
            var actual_two = gameboard.actualStatusGrid[2, 3].status;
            var actual_three = gameboard.actualStatusGrid[3, 3].status;
            var actual_four = gameboard.actualStatusGrid[2, 2].status;
            var actual_five = gameboard.actualStatusGrid[2, 4].status;
            var expected = true;
            var expected_false = false;

            // Assert
            Assert.AreEqual(actual_one, expected);
            Assert.AreEqual(actual_two, expected);
            Assert.AreEqual(actual_three, expected);
            Assert.AreEqual(actual_four, expected_false);
            Assert.AreEqual(actual_five, expected_false);
        }
        [TestMethod]
        public void GameboardCreateNextGridCompleteBlinker()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act
            gameboard.actualStatusGrid[2, 2].status = true;
            gameboard.actualStatusGrid[2, 3].status = true;
            gameboard.actualStatusGrid[2, 4].status = true;
            gameboard.checkNeighbors();
            gameboard.nextGen();
            gameboard.checkNeighbors();
            gameboard.nextGen();
            var actual_one = gameboard.actualStatusGrid[2, 2].status;
            var actual_two = gameboard.actualStatusGrid[2, 3].status;
            var actual_three = gameboard.actualStatusGrid[2, 4].status;
            var expected = true;

            // Assert
            Assert.AreEqual(actual_one, expected);
            Assert.AreEqual(actual_two, expected);
            Assert.AreEqual(actual_three, expected);
        }
        [TestMethod]
        public void GameboardCreateNextGridCompleteBlinkerInCorner()
        {
            // Arrange
            Gameboard gameboard = new Gameboard();

            // Act
            gameboard.actualStatusGrid[9, 0].status = true;
            gameboard.actualStatusGrid[0, 0].status = true;
            gameboard.actualStatusGrid[1, 0].status = true;
            gameboard.checkNeighbors();
            gameboard.nextGen();
            gameboard.checkNeighbors();
            gameboard.nextGen();
            var actual_one = gameboard.actualStatusGrid[9, 0].status;
            var actual_two = gameboard.actualStatusGrid[0, 0].status;
            var actual_three = gameboard.actualStatusGrid[1, 0].status;
            var expected = true;

            // Assert
            Assert.AreEqual(actual_one, expected);
            Assert.AreEqual(actual_two, expected);
            Assert.AreEqual(actual_three, expected);
        }
    }
}
