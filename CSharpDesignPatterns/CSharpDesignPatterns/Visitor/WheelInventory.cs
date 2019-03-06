using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelInventory : IWheelVisitor

    {
        private int _spokCount;
        private int _bearingsCount;

        public WheelInventory()
        {
            _spokCount = 30;
            _bearingsCount = 2;

        }
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("The Wheel has : {0}spok and {1} bearings", _spokCount, _bearingsCount);
        }

        public void Visit(Spoks spoks)
        {
            _spokCount++;
        }

        public void Visit(Bearings bearings)
        {
            _bearingsCount++;
        }
    }
}
