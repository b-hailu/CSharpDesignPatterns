using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Observer
{
    public class SpeedMoniter : ISpeedChange
    {
        public const int SpeedToAlert = 30;

        public SpeedMoniter(Speedometer speed)
        {

            speed.VChanged += ValueHasChanged;

        }

        public void ValueHasChanged(object sender, EventArgs args)
        {
            Speedometer mySpeed = (Speedometer)sender;
            if (mySpeed.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine("** AlERT ** Riding to fast!  (" + mySpeed.CurrentSpeed + ")");
            }
            else
            {
                Console.WriteLine("nice and steady...(" + mySpeed.CurrentSpeed + ")");
            }
        }
    }
}
