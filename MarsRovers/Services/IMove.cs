using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Services
{
    interface IMove
    {
        void TurnLeft();
        void TurnRight();
        void MoveForward();

    }
}
