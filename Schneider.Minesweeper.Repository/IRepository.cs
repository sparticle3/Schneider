namespace Schneider.Minesweeper.Repository
{
    /// <summary>
    /// Generic repository interface definition.
    /// </summary>
    /// <typeparam name="T">The type to return.</typeparam>
    public interface IRepository<out T>
    {
        /// <summary>
        /// Returns an item.
        /// </summary>
        /// <returns>An Item</returns>
        T Get();
    }
}