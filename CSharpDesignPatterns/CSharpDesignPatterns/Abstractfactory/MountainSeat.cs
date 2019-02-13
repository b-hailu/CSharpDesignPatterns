using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    public class MountainSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return " Seat for Montain Bike"; }
        }
    }
}
