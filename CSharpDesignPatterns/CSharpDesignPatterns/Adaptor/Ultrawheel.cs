using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class Ultrawheel
    {
        private int _size;

        public int wheelSize
        {
            get { return _size; }
        }

        public Ultrawheel(int size)
        {
            this._size = size;
        }

        public override string ToString()
        {
            return "ULTRAWHEEL " + _size;
        }
    }
}
