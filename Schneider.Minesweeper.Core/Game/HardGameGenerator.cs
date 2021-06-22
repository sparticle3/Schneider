namespace Schneider.Minesweeper.Core.Game
{
    /// <summary>
    ///  A hard game generator.
    /// </summary>
    /// <seealso cref="IGameGenerator" />
    public class HardGameGenerator : IGameGenerator
    {
        public const int Lives = 3;
        public const int Dimension = 3;
        public const int NumberOfMines = 6;

        /// <summary>
        /// Gets the game.
        /// </summary>
        /// <returns>
        /// The game.
        /// </returns>
        public Model.Game GetGame()
        {
            var game = new Model.Game(Lives)
            {
                Grid = new Model.Grid(Dimension, NumberOfMines)
            };

            return game;
        }
    }
}