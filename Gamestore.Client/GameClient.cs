using System.Reflection.Metadata.Ecma335;
using Gamestore.Models;

namespace Gamestore.Client
{
    public static class GameClient
    {
        private static readonly List<Game> gameList = new List<Game> {
            new Game() {
                Id = 1,
                Name = "Street Fighter II",
                Genre = "Fighting",
                Price = 19.99M,
                ReleaseDate = new DateTime(1991, 2, 1)
            },
            new Game() {
                Id = 2,
                Name = "Final Fantasy XIV",
                Genre = "Role Playing",
                Price = 59.99M,
                ReleaseDate = new DateTime(2010, 9, 30)
            },
            new Game() {
                Id = 3,
                Name = "Fifa 2023",
                Genre = "Sports",
                Price = 69.99M,
                ReleaseDate = new DateTime(2022, 9, 27)
            },
            new Game() {
                Id = 4,
                Name = "Mario Kart",
                Genre = "Racing",
                Price = 59.95M,
                ReleaseDate = new DateTime(1992, 9, 22)
            }
        };

        public static List<Game> Games()
        {
            return gameList;
        }

        public static void AddGame(Game game)
        {
            game.Id = gameList.Max(g => g.Id) + 1;
            gameList.Add(game);
            Console.WriteLine(gameList.Count);
        }

        public static void UpdateGame(Game game)
        {
            var gameInList = GetGame(game.Id);
            gameInList.Name = game.Name;
            gameInList.Genre = game.Genre;
            gameInList.Price = game.Price;  
            gameInList.ReleaseDate = game.ReleaseDate;
        }

        public static Game GetGame(int id) {
            return gameList.Find(g => g.Id == id) ?? throw new Exception("Invalid Game Id!");
        }

        public static void DeleteGame(int id)
        {
            Game game = GetGame(id);
            gameList.Remove(game);
        }
    }
}