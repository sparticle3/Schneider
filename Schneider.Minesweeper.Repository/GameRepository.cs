using Schneider.Minesweeper.Core.Game;
using Schneider.Minesweeper.Model;

namespace Schneider.Minesweeper.Repository
{
    /// <summary>
    /// Repository to retrieve a game.
    /// </summary>
    /// <seealso cref="IRepository{Game}" />
    public class GameRepository : IRepository<Game>
    {        
        private readonly IGameGenerator _gameGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameRepository"/> class.
        /// </summary>
        /// <param name="gameGenerator">The game generator.</param>
        public GameRepository(IGameGenerator gameGenerator)
        {
            _gameGenerator = gameGenerator;
        }

        /// <summary>
        /// Returns a game.
        /// </summary>
        /// <returns>
        /// A game.
        /// </returns>
        public Game Get()
        {
            return _gameGenerator.GetGame();
        }
    }
}