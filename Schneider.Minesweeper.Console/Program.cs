using System;
using System.Text;
using Autofac;
using Schneider.Minesweeper.Core.Game;
using Schneider.Minesweeper.Model;
using Schneider.Minesweeper.Repository;

namespace Schneider.Minesweeper.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            var game = container.Resolve<IRepository<Game>>().Get();
            PrintInstructionsToConsole(game);

            ConsoleKeyInfo keyInfo;
            GameResult gameResult;
            do
            {
                keyInfo = System.Console.ReadKey();
                gameResult = game.Move(keyInfo.KeyChar);
                System.Console.WriteLine(Environment.NewLine + game);

            } while (keyInfo.Key != ConsoleKey.Enter && gameResult == GameResult.InProgress);

            switch (gameResult)
            {
                case GameResult.Won:
                    System.Console.WriteLine("You Won! Congratulations.");
                    break;
                case GameResult.OutOfLives:
                    System.Console.WriteLine("You ran out of lives :(");
                    break;
                default:
                    throw new ApplicationException($"Game result {gameResult} is not valid.");
            }
        }

        private static void PrintInstructionsToConsole(Game game)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Game is about to start.");
            stringBuilder.AppendLine("Keys are: u=UP, d=DOWN, l=LEFT, r=RIGHT");
            stringBuilder.AppendLine($"Grid size is {game.Grid.Dimension} x {game.Grid.Dimension}");
            stringBuilder.AppendLine($"Number of mines = {game.Grid.NumberOfMines}");
            stringBuilder.AppendLine($"Number of lives = {game.Lives}");
            stringBuilder.AppendLine("Press <Enter> to exit at any time... ");
            stringBuilder.AppendLine("Good Luck");
            stringBuilder.AppendLine(game.ToString());

            System.Console.WriteLine(stringBuilder.ToString());
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GameRepository>().As<IRepository<Game>>();
            builder.RegisterType<EasyGameGenerator>().As<IGameGenerator>();
            return builder.Build();
        }
    }
}
