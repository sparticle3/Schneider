namespace Schneider.Minesweeper.Core.Game
{
    /// <summary>
    /// An easy game generator.
    /// </summary>
    /// <seealso cref="IGameGenerator" />
    public class EasyGameGenerator : IGameGenerator
    {
        public const int Lives = 3;
        public const int Dimension = 3;
        public const int NumberOfMines = 3;

        /// <summary>
        /// Gets the game.
        /// </summary>
        /// <returns>
        /// The game.
        /// </returns>
        public Model.Game GetGame()
        {
            return new Model.Game(Lives)
            {
                Grid = new Model.Grid(Dimension, NumberOfMines)
            };
        }
    }
}