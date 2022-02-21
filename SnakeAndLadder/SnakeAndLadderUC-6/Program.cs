using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int position = 0;
            int diceRolledCount = 0;
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;
            while (position < 100)
            {
                int DiceNo = random.Next(1, 7);
                int options = random.Next(1, 4);
                switch (options)
                {
                    case LADDER:
                        position += DiceNo;
                        position = Math.Min(position, 100);
                        break;
                    case NOPLAY:
                        break;
                    case SNAKE:
                        position -= DiceNo;
                        position = Math.Max(position, 0);
                        break;
                }
                diceRolledCount++;
                Console.WriteLine("The current position is " + position);
            }
            Console.WriteLine("No of times dice was rolled " + diceRolledCount);
        }
    }
}