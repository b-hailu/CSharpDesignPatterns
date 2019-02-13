using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;// added to access the name space

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    {
        /*
        class object AbstractRoadBike
        is assigned by the constructor and retrived by the property Bicycle
        */
        private AbstractRoadBike _roadBikeInProgress;

        /*  AbstractRoadBike    is a class in a Base folder
         * property of RoadBikeBuilder used to return an object of IBicycle. 
         * this object is of type AbstractRoadBike that implements the IBicycle interface
         
         */

        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;
            }


        }
        /*
         * constructor of the class RoadBikeBuilder that takes a parameter of AbstractRoadBike and 
         * assigns that parameter to the the class field _roadBikeInProgress
              */

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;

            /*
             * method
             * public -accessmodifier
             * override - used to define its behavior instead of the parent class that is extends
             * void - noreturn type
             */
        }

        public override void BuildStreetTires()
        {
            Console.WriteLine("building  RoadBike Street Tires.");
        }
        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike Handle Bars");
        }
    }
}
