using NUnit.Framework;
using Schneider.Minesweeper.Core.Game;

namespace Schneider.Minesweeper.Core.Tests
{
    public class HardGameGeneratorTests
    {
        private IGameGenerator _gameGenerator;

        [SetUp]
        public void Setup()
        {
            _gameGenerator = new HardGameGenerator();
        }

        [Test]
        public void GetGame_GameParametersLives_AreCorrect()
        {
            // arrange

            // act
            var actualGame = _gameGenerator.GetGame();

            // assert
            Assert.AreEqual(3, actualGame.Lives);
        }

        [Test]
        public void GetGame_GameParametersGrid_IsNotNull()
        {
            // arrange

            // act
            var actualGame = _gameGenerator.GetGame();

            // assert
            Assert.NotNull(actualGame.Grid);
        }

        [Test]
        public void GetGame_GameParametersGrid_HasExpectedMines()
        {
            // arrange

            // act
            var actualGame = _gameGenerator.GetGame();

            // assert
            Assert.AreEqual(6, actualGame.Grid.NumberOfMines);
        }

        [Test]
        public void GetGame_GameParametersGrid_HasExpectedDimensions()
        {
            // arrange

            // act
            var actualGame = _gameGenerator.GetGame();

            // assert
            Assert.AreEqual(3, actualGame.Grid.Dimension);
        }

        [Test]
        public void GetGame_GameParametersPosition_HasExpectedInitialPositionX()
        {
            // arrange

            // act
            var actualGame = _gameGenerator.GetGame();

            // assert
            Assert.AreEqual(0, actualGame.Position.X);
        }

        [Test]
        public void GetGame_GameParametersPosition_HasExpectedInitialPositionY()
        {
            // arrange

            // act
            var actualGame = _gameGenerator.GetGame();

            // assert
            Assert.AreEqual(0, actualGame.Position.Y);
        }
    }
}