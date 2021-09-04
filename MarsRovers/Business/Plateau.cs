using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.Business
{
    public class Plateau
    {
        public int PlatueXMax { get; set; }
        public int PlatueYmax { get; set; }

        public const int PlatueXMin = 0;

        public const int PlatueYMin = 0;

        public Plateau(List<int> maxPlatues)
        {
            PlatueXMax = maxPlatues[0];
            PlatueYmax = maxPlatues[1];
        }
    }
}
