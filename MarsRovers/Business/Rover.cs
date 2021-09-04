using MarsRovers.Enums;
using MarsRovers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Business
{
    public class Rover : IMove
    {

        #region DeclaringVariable
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public char direction { get; set; }

        #endregion

        public Rover(string position)
        {
            coordinateX = Convert.ToInt32(position.Split(" ")[0].Trim());
            coordinateY = Convert.ToInt32(position.Split(" ")[1].Trim());
            direction = Convert.ToChar(position.Split(" ")[2].Trim());
        }


        #region BusinessMethods

        public void MovewithNasaCommand(string nasaCommands)
        {

            char[] commands = nasaCommands.ToCharArray();


            for (int i = 0; i < commands.Length; i++)
            {

                switch (commands[i])
                {

                    case (char)Commands.Left:
                        TurnLeft();
                        break;
                    case (char)Commands.Right:
                        TurnRight();
                        break;
                    case (char)Commands.MoveForward:
                        MoveForward();
                        break;
                    default:
                        break;
                }
            }
        }

        public void TurnLeft()
        {
            switch (direction)
            {
                case (char)Directions.North:
                    direction = (char)Directions.West;
                    break;
                case (char)Directions.East:
                    direction = (char)Directions.North;
                    break;
                case (char)Directions.South:
                    direction = (char)Directions.East;
                    break;
                case (char)Directions.West:
                    direction = (char)Directions.South;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case (char)Directions.North:
                    direction = (char)Directions.East;
                    break;
                case (char)Directions.East:
                    direction = (char)Directions.South;
                    break;
                case (char)Directions.South:
                    direction = (char)Directions.West;
                    break;
                case (char)Directions.West:
                    direction = (char)Directions.North;
                    break;
                default:
                    break;
            }
        }

        public void MoveForward()
        {
            switch (direction)
            {
                case (char)Directions.North:
                    coordinateY += 1;
                    break;
                case (char)Directions.East:
                    coordinateX += 1;
                    break;
                case (char)Directions.South:
                    coordinateY -= 1;
                    break;
                case (char)Directions.West:
                    coordinateX -= 1;
                    break;
                default:
                    break;
            }
        }

        #endregion

    }
}
