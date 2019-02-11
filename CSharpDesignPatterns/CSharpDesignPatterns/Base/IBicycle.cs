using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public interface IBicycle
    {
        IWheel GetWheel { get; }

        BikeColor ColorType { get; }

        void paint(BikeColor color);
    }
}
