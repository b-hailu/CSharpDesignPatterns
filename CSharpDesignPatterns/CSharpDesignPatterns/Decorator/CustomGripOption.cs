using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public class CustomGripOption : AbstractBikeOption
    {
        public override decimal price
        {
            get { return decoratedBike.price + 20.00m; }
        }

        public CustomGripOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
