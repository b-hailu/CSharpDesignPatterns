using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    public abstract class AbstractBikeFactory
    {
        public abstract IBikeFrame CreatBikeFrame();
        public abstract IBikeSeat CreatBikeSeat();
    }
}
