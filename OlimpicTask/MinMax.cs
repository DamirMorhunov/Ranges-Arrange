using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicTask
{
    class MinMax<T>
    {
        private T[] _values;
        public MinMax(T[] values)
        {
            _values = values;
        }
        public T Min() => _values.Min();
        public T Max() => _values.Max();
    }
}
