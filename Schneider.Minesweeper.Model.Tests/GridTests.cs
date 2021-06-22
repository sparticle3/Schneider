using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Schneider.Minesweeper.Model.Tests
{
    public class GridTests
    {
        private Grid _grid;

        [Test]
        public void IsCollision_HasMineAtPosition_True()
        {
            // arrange
            _grid = new Grid(1, 1);

            // act
            var position = new Position();
            var isCollision = _grid.IsCollision(position);

            // assert
            Assert.True(isCollision);
        }

        [Test]
        public void IsCollision_HasNoMineAtPosition_False()
        {
            // arrange
            _grid = new Grid(1, 0);

            // act
            var position = new Position();
            var isCollision = _grid.IsCollision(position);

            // assert
            Assert.False(isCollision);
        }

        [Test]
        public void IsValidPosition_InsideGrid_True()
        {
            // arrange
            _grid = new Grid(1, 1);

            // act
            var position = new Position();
            var isValidPosition = _grid.IsValidPosition(position);

            // assert
            Assert.True(isValidPosition);
        }

        [Test]
        public void IsValidPosition_OutsideGrid_False()
        {
            // arrange
            _grid = new Grid(1, 1);

            // act
            var position = new Position() { X = 1, Y = 1 };
            var isValidPosition = _grid.IsValidPosition(position);

            // assert
            Assert.False(isValidPosition);
        }

        [Test]
        public void IsAtEnd_IsEndColumn_True()
        {
            // arrange
            _grid = new Grid(1, 1);

            // act
            var position = new Position();
            var isAtEnd = _grid.IsAtEnd(position);

            // assert
            Assert.True(isAtEnd);
        }

        [Test]
        public void IsAtEnd_IsNotEndColumn_False()
        {
            // arrange
            _grid = new Grid(3, 1);

            // act
            var position = new Position();
            var isAtEnd = _grid.IsAtEnd(position);

            // assert
            Assert.False(isAtEnd);
        }
    }
}