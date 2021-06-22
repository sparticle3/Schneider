namespace Schneider.Minesweeper.Model
{
    /// <summary>
    /// A structure to hold a two dimensional position object.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        public int Y { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"[X:{X}, Y:{Y}]";
        }

        /// <summary>
        /// Gets the Origin.
        /// </summary>
        /// <returns>A position.</returns>
        public static Position Origin()
        {
            return new Position() { X = 0, Y = 0 };
        }

        /// <summary>
        /// Moves up.
        /// </summary>
        /// <returns>The new position.</returns>
        public Position Up()
        {
            return new Position() { X = this.X, Y = this.Y + 1 };
        }

        /// <summary>
        /// Moves down.
        /// </summary>
        /// <returns>The new position.</returns>
        public Position Down()
        {
            return new Position() { X = this.X, Y = this.Y - 1 };
        }

        /// <summary>
        /// Moves left.
        /// </summary>
        /// <returns>The new position.</returns>
        public Position Left()
        {
            return new Position() { X = this.X - 1, Y = this.Y };
        }

        /// <summary>
        /// Moves right.
        /// </summary>
        /// <returns>The new position.</returns>
        public Position Right()
        {
            return new Position() { X = this.X + 1, Y = this.Y };
        }

        #region equality
        protected bool Equals(Position other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Position)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
        #endregion
    }
}