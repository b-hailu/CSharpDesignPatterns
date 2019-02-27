using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public class LeatherSheetOption : AbstractBikeOption
    {
        public override decimal price
        {
            get { return decoratedBike.price + 11.00m; }
        }

        public LeatherSheetOption(IBicycle bicycle)
            : base(bicycle) { }
    }
}
