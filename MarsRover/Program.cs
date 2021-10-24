using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2);

            // Create rover instance
            Rover rover = new Rover(plateau, position, DirectionEnum.N);
            rover.Process("LMLMLMLMM");
            Console.WriteLine(rover.CurrentPosition()); // 1 3 N


            rover.SetPosition(3, 3, DirectionEnum.E);
            rover.Process("MMRMMRMRRM");
            Console.WriteLine(rover.CurrentPosition()); // 5 1 E
            Console.ReadLine();
        }
    }
}
