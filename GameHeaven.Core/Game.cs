using System;
using System.Collections.Generic;
using System.Text;

namespace GameHeaven.Core
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayingTime { get; set; }
        public int MinNumberOfPlayers { get; set; }
        public int MaxNumberOfPlayers { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public GameCategory Category { get; set; }
        public Publisher Publisher { get; set; }

        public string Ages
        {
            get
            {
                return MaxAge == 99 ? $"{MinAge}+" : $"{MinAge} - {MaxAge}";
            }
        }

        public string Players
        {
            get
            {
                return $"{MinNumberOfPlayers} - {MaxNumberOfPlayers}";
            }
        }
    }
}
