using MarsRovers.Business;
using System;
using System.Collections.Generic;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test inputs are taken from case document. 
            //First Input : Plateau Coordinate
            //Second Input : Rover location
            //Last Output : Nasa commands for a rover

            List<int> maxPlateauPositions = new List<int>() { 5, 5 };
            Plateau plateau = new Plateau(maxPlateauPositions);

            Rover firstRover = new Rover("1 2 N");
            string firstNasaCommands = "LMLMLMLMM";
            firstRover.MovewithNasaCommand(firstNasaCommands);


            Rover secondRover = new Rover("3 3 E");
            string secondNasaCommands = "MMRMMRMRRM";
            secondRover.MovewithNasaCommand(secondNasaCommands);
        }
    }
}
