using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractfactory;
using Builder;
using Singleton;
using Adaptor;
using Decorator;


namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorPatternDemo();
            //AdaptorpatternDemo();
            //SingletonPatternDemo();
            //BuilderPatternDemo();
            //AbstractFactoryDemo();
        }

        private static void DecoratorPatternDemo()
        {
            //standrad touring bike
            IBicycle myTourbike = new Touring(new NarrowWheel(24));
            Console.WriteLine(myTourbike);

            //Touring bike with Custom grips
            myTourbike = new CustomGripOption(myTourbike);
            Console.WriteLine(myTourbike);

            //tour bike with leather seat
            myTourbike = new LeatherSheetOption(myTourbike);
            Console.WriteLine(myTourbike);
            //tour bike with whitetire

            myTourbike = new WhiteTireOption(myTourbike);
            Console.WriteLine(myTourbike);

        }

        private static void AdaptorpatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdaptor(new Ultrawheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial" + generator.NextSerial);//either one of these is the proper way of calling
            Console.WriteLine("next serial" + SerialNumberGenerator.Instance.NextSerial);//either one of these is the proper way of calling
            Console.WriteLine("next serial" + generator.NextSerial);//either one of these is the proper way of calling
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new
                Downhill(BikeColor.Green, new WideWheel(24));

            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        private static void AbstractFactoryDemo()
        {
            /* parent class object instance is created by its child
             class. this parebt class can only see methods that it created, that its child uses.
             any child types created can not be seen unless it was first created  by parents.

             */
            AbstractBikeFactory factory = new RoadBikeFactory();
            /* creat the bike parts
             * Interface object is created. the factory object is created
             * above calles the method that returns the interface that it is assigned to.
             * these creat methods creat a new object of a frame or seat. these object can be either road 
              mountain.in these case the roadframe and roadseat
              */


            IBikeFrame bikeframe = factory.CreatBikeFrame();

            //creatbikeframe method of factory object @ returns Ibikeframe to object bikeframe

            IBikeSeat bikeSeat = factory.CreatBikeSeat();

            //creatbikeseat method of factory object @ returns IBikeSeat to object bikeseat

            //shaw what we created , bikeframeparts and bikeseat parts are properties

            /*interface object bikeframe calls the property BikeFrameParts
             * bikeframe was created from the class bikeframe
             * the property bikeframeparts use the get to return 
             * the string value from Bikefram
             */


            Console.WriteLine(bikeframe.BikeFrameParts);

            /*interface object bikeseat calls the property BikeseatParts
             * bikeseat was created from the class roadseat
             * the property bikeseatparts use the get to return 
             * the string value from roadseat
             */
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}









