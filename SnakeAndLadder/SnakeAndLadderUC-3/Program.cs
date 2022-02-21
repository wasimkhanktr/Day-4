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
            int DiceNo = random.Next(1, 7);
            int options = random.Next(1, 4);
            int position = 0;
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;
            switch (options)
            {
                case LADDER:
                    position += DiceNo;
                    break;
                case NOPLAY:
                    break;
                case SNAKE:
                    position -= DiceNo;
                    break;
            }
            Console.WriteLine("position is " + position);
        }
    }
}