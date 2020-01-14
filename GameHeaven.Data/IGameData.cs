using GameHeaven.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameHeaven.Data
{
    public interface IGameData
    {
        IEnumerable<Game> GetAll();
    }

    public class InMemoryGameData : IGameData
    {
        readonly List<Game> games;

        public InMemoryGameData()
        {
            games = new List<Game>()
            {
                new Game { Id = 1, Name = "Kniffel", 
                            MinAge = 8, MaxAge = 99, 
                            MinNumberOfPlayers = 2, MaxNumberOfPlayers = 8, 
                            PlayingTime = 30, Category = new GameCategory { Description = "Wuerfelspiel"}
                },
                new Game { Id = 2, Name = "Skip Bo",
                            MinAge = 7, MaxAge = 99,
                            MinNumberOfPlayers = 2, MaxNumberOfPlayers = 6,
                            PlayingTime = 20, Category = new GameCategory { Description = "Kartenspiel"}
                            }
            };
        }
        public IEnumerable<Game> GetAll()
        {
            return games.OrderBy(g => g.Name);
        }
    }
}
