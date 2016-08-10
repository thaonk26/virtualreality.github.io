using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualReality
{
    class Game
    {
        Player mainPlayer;

        public Game()
        {
            Console.WriteLine("Welcome to the Royal World!\n What should we call you by?");
            this.mainPlayer = new Player(Console.ReadLine());
        }
        public void RunProgram()
        {
            Console.WriteLine("We warmly welcome you {0}", mainPlayer.seePlayer());
            startingTown();
        }
        public string startingTown()
        {
            Console.WriteLine("What town would you like to start at?\n Azure Town, Silver Town or Crimson Town?");
            mainPlayer.startingTown(Console.ReadLine());
            switch (mainPlayer.setTown())
            {
                case "azure":
                    Console.WriteLine("nice choice choosing the blue color");
                    break;
                case "silver":
                    Console.WriteLine("thats a great color");
                    break;
                case "crimson":
                    Console.WriteLine("a deep red color like blood");
                    break;
                default:
                    Console.WriteLine("umm....thats not a town");
                    break;
            }
            return mainPlayer.setTown();
        }
    }
}
