using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualReality
{
    class Player
    {
        string player;
        string town;

        public Player(string player)
        {
            this.player = player;
        }
        public string seePlayer()
        {
            return this.player;
        }
        public void startingTown(string town)
        {
            this.town = town;
        }
        public string setTown()
        {
            return town;
        }
    }
}
