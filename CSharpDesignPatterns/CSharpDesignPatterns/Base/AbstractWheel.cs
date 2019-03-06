using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpDesignPatterns
{
    public abstract class AbstractWheel : IWheel
    {
        private int _size;
        private bool _IsWide;
        private Spoks _spoks;
        private Bearings _bearings;

        public int Size
        {
            get
            {
                return _size;
            }


        }

        public bool IsWide
        {

            get
            {
                return _IsWide;
            }


        }

        public AbstractWheel(int size, bool isWide)
        {
            this._size = size;
            this._IsWide = isWide;
            _spoks = new Spoks();
            _bearings = new Bearings();
        }

        public virtual void AcceptVisitor(IWheelVisitor visitor)
        {
            _spoks.AcceptVisitor(visitor);
            _bearings.AcceptVisitor(visitor);
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " with a wheel size of " + _size + "inches";
        }
    }


}
