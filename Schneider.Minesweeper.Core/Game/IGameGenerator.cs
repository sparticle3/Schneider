namespace Schneider.Minesweeper.Core.Game
{
    /// <summary>
    /// The game generator interface.
    /// </summary>
    public interface IGameGenerator
    {
        /// <summary>
        /// Gets the game.
        /// </summary>
        /// <returns>The game.</returns>
        Model.Game GetGame();
    }
}
