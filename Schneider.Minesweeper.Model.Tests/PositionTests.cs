using NUnit.Framework;

namespace Schneider.Minesweeper.Model.Tests
{
    public class PositionTests
    {
        private Position _position;

        [SetUp]
        public void Setup()
        {
            _position = new Position();
        }

        [Test]
        public void Up_Increments_Y()
        {
            // arrange

            // act
            var position = _position.Up();

            // assert
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(1, position.Y);
        }

        [Test]
        public void Down_Decrements_Y()
        {
            // arrange

            // act
            var position = _position.Down();

            // assert
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(-1, position.Y);
        }

        [Test]
        public void Left_Decrements_X()
        {
            // arrange

            // act
            var position = _position.Left();

            // assert
            Assert.AreEqual(-1, position.X);
            Assert.AreEqual(0, position.Y);
        }

        [Test]
        public void Right_Increments_X()
        {
            // arrange

            // act
            var position = _position.Right();

            // assert
            Assert.AreEqual(1, position.X);
            Assert.AreEqual(0, position.Y);
        }

        [Test]
        public void Equal_TwoIdenticalPositions_AreEqual()
        {
            // arrange
            var position1 = new Position();
            var position2 = new Position();

            // act
            var equal = position1.Equals(position2);

            // assert
            Assert.True(equal);
        }
    }
}