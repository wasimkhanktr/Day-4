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
            int position = random.Next(1, 7);
            Console.WriteLine("position of dice is " + position);
        }
    }
}