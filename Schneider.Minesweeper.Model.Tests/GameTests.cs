using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Schneider.Minesweeper.Model.Tests
{
    public class GameTests
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game(1) { Grid = new Grid(2, 0) };
        }

        [Test]
        public void Move_ValidMoveReachedEnd_StateIsWon()
        {
            // arrange

            // act
            var state = _game.Move('r');

            // assert
            Assert.AreEqual(GameResult.Won, state);
        }

        [Test]
        public void Move_ValidMoveNotReachedEnd_StateIsInProgress()
        {
            // arrange
            _game = new Game(1) { Grid = new Grid(20, 0) };

            // act
            var state = _game.Move('r');

            // assert
            Assert.AreEqual(GameResult.InProgress, state);
        }

        [Test]
        public void Move_InValidMove_StateIsInProgress()
        {
            // arrange

            // act
            var state = _game.Move('l');

            // assert
            Assert.AreEqual(GameResult.InProgress, state);
        }

        [Test]
        public void Move_InValidMoveLeft_NoMovement()
        {
            // arrange

            // act
            _game.Move('l');

            // assert
            Assert.AreEqual(Position.Origin().X, _game.Position.X);
            Assert.AreEqual(Position.Origin().Y, _game.Position.Y);
        }

        [Test]
        public void Move_InValidMoveDown_NoMovement()
        {
            // arrange

            // act
            _game.Move('d');

            // assert
            Assert.AreEqual(Position.Origin().X, _game.Position.X);
            Assert.AreEqual(Position.Origin().Y, _game.Position.Y);
        }

        [Test]
        public void Move_ValidMoveNotReachedEndRight_PositionChanged()
        {
            // arrange
            _game = new Game(1) { Grid = new Grid(20, 0) };

            // act
            _game.Move('r');

            // assert
            Assert.AreEqual(Position.Origin().X + 1, _game.Position.X);
            Assert.AreEqual(Position.Origin().Y, _game.Position.Y);
        }

        [Test]
        public void Move_ValidMoveNotReachedEndUp_PositionChanged()
        {
            // arrange
            _game = new Game(1) { Grid = new Grid(20, 0) };

            // act
             _game.Move('u');

            // assert
            Assert.AreEqual(Position.Origin().X, _game.Position.X);
            Assert.AreEqual(Position.Origin().Y + 1, _game.Position.Y);
        }
    }
}