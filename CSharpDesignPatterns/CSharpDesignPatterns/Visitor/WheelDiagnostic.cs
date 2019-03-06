using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostic : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing Wheel");
        }

        public void Visit(Spoks spoks)
        {
            Console.WriteLine("Diagnosing Spoks");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("Diagnosing Bearing");
        }
    }
}
