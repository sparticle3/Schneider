using System;

namespace Schneider.Minesweeper.Model
{
    /// <summary>
    /// The Game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        /// <param name="lives">The lives.</param>
        public Game(int lives)
        {
            Lives = lives;
        }

        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public Grid Grid { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Position Position { get; set; } = Position.Origin();

        /// <summary>
        /// Gets or sets the lives.
        /// </summary>
        /// <value>
        /// The lives.
        /// </value>
        public int Lives { get; set; }

        /// <summary>
        /// Gets or sets the moves.
        /// </summary>
        /// <value>
        /// The moves.
        /// </value>
        public int Moves { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Lives Remaining = {Lives}, Moves = {Moves}, Current Position = {Position}";
        }

        /// <summary>
        /// Moves in the specified direction.
        /// </summary>
        /// <param name="direction">The direction.</param>
        /// <returns>The game result.</returns>
        public GameResult Move(char direction)
        {
            var newPosition = GetNewPosition(direction);
            if (!Grid.IsValidPosition(newPosition))
            {
                Console.WriteLine(Environment.NewLine + "That is not a valid move, try again.");
                return GameResult.InProgress;
            }

            Position = newPosition;
            Moves++;

            if (Grid.IsCollision(Position))
            {
                Console.WriteLine(Environment.NewLine + "Uh oh, collision!");
                Lives--;
            }

            return GetGameResult();
        }

        private GameResult GetGameResult()
        {
            if (Lives == 0)
            {
                return GameResult.OutOfLives;
            }

            if (Grid.IsAtEnd(Position))
            {
                return GameResult.Won;
            }

            return GameResult.InProgress;
        }

        private Position GetNewPosition(char direction)
        {
            Position newPosition;
            switch (direction)
            {
                case 'u':
                    newPosition = Position.Up();
                    break;
                case 'd':
                    newPosition = Position.Down();
                    break;
                case 'l':
                    newPosition = Position.Left();
                    break;
                case 'r':
                    newPosition = Position.Right();
                    break;
                default:
                    throw new ArgumentException($"Direction {direction} is not valid.");
            }

            return newPosition;
        }
    }
}
