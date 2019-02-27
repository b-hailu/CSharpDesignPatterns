using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Adaptor
{
    class UltraWheelAdaptor : AbstractWheel
    {
        public UltraWheelAdaptor(Ultrawheel ultrawheel)
            : base(ultrawheel.wheelSize, false) { }
    }
}
