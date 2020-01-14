using System;
using System.Collections.Generic;
using System.Text;

namespace GameHeaven.Core
{
    public class Team
    {
        public User Founder { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public int MaxPlayers { get; set; }
    }
}
