using Moq;
using NUnit.Framework;
using Schneider.Minesweeper.Core.Game;
using Schneider.Minesweeper.Model;

namespace Schneider.Minesweeper.Repository.Tests
{
    public class GameRepositoryTests
    {
        private IRepository<Game> _repository;
        private readonly Mock<IGameGenerator> _gameGeneratorMock = new Mock<IGameGenerator>(MockBehavior.Strict);

        [SetUp]
        public void Setup()
        {
            var returnedGame = new Game(3);

            _gameGeneratorMock.Setup(g => g.GetGame()).Returns(returnedGame);
            _repository = new GameRepository(_gameGeneratorMock.Object);
        }

        [Test]
        public void Get_CallsIntoGenerator_GeneratorIsCalled()
        {
            // arrange
            var returnedGame = new Game(3);
            _gameGeneratorMock.Setup(g => g.GetGame()).Returns(returnedGame);
            _repository = new GameRepository(_gameGeneratorMock.Object);

            // act
            var game = _repository.Get();

            // assert
            Mock.Verify();
        }

        [Test]
        public void Get_CallsIntoGenerator_GameIsAsExpected()
        {
            // arrange
            var returnedGame = new Game(3);
            _gameGeneratorMock.Setup(g => g.GetGame()).Returns(returnedGame);
            _repository = new GameRepository(_gameGeneratorMock.Object);

            // act
            var game = _repository.Get();

            // assert
            Assert.IsTrue(returnedGame == game);
        }
    }
}