using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;
namespace Observer
{
    interface ISpeedChange
    {
        void ValueHasChanged(object sender, EventArgs args);

    }
}
