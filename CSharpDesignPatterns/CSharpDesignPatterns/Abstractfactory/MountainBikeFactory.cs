using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreatBikeFrame()
        {
            return new MountainFrame();
        }

        public override IBikeSeat CreatBikeSeat()
        {
            return new MountainSeat();
        }
    }
}
