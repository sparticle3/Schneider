using System;
using System.Collections.Generic;

namespace Schneider.Minesweeper.Model
{
    /// <summary>
    /// A two dimensional grid.
    /// </summary>
    public class Grid
    {
        private readonly List<Position> _minePositions = new List<Position>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="dimension">The dimension.</param>
        /// <param name="numberOfMines">The number of mines.</param>
        public Grid(int dimension, int numberOfMines)
        {
            Dimension = dimension;
            NumberOfMines = numberOfMines;

            for (var i = 0; i < numberOfMines; i++)
            {
                var minePosition = new Position()
                {
                    X = new Random().Next(0, Dimension - 1),
                    Y = new Random().Next(0, Dimension - 1)
                };
                _minePositions.Add(minePosition);
            }
        }

        /// <summary>
        /// Gets or sets the dimension.
        /// </summary>
        /// <value>
        /// The dimension.
        /// </value>
        public int Dimension { get; set; }

        /// <summary>
        /// Gets or sets the number of mines.
        /// </summary>
        /// <value>
        /// The number of mines.
        /// </value>
        public int NumberOfMines { get; set; }

        /// <summary>
        /// Determines whether the specified position is collision.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>
        ///   <c>true</c> if the specified position is collision; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCollision(Position position)
        {
            return _minePositions.Contains(position);
        }

        /// <summary>
        /// Determines whether the specified position is valid.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>
        ///   <c>true</c> if [is valid position] [the specified position]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidPosition(Position position)
        {
            return position.X >= 0 && position.X < Dimension
                && position.Y >= 0 && position.Y < Dimension;
        }

        /// <summary>
        /// Determines whether the specified position is at the far right of the grid.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>
        ///   <c>true</c> if [is at end] [the specified position]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAtEnd(Position position)
        {
            return position.X == Dimension - 1;
        }
    }
}
