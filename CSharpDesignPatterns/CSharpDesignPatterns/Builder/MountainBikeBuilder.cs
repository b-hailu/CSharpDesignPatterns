using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; //we add this to access the name space

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        /*
        class object AbstractMountainBike
        is assigned by the constructor and retrived by the property Bicycle
        */
        private AbstractMountainBike _mountainBikeInProgress;

        /*  AbstractMountainBike    is a class in a Base folder
         * property of MountainBikeBuilder used to return an object of IBicycle. 
         * this object is of type AbstractMountainBike that implements the IBicycle interface
         
         */

        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;
            }


        }
        /*
         * constructor of the class MountainBikeBuilder that takes a parameter of AbstractMountainBike and 
         * assigns that parameter to the the class field _mountainBikeInProgress
              */

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;

            /*
             * method
             * public -accessmodifier
             * override - used to define its behavior instead of the parent class that is extends
             * void - noreturn type
             */
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("building  MountainBike Wide Tires.");
        }
        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handle Bars");
        }
    }
}
