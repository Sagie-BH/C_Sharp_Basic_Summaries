using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructPrac
{
    struct MyNullable<T> where T : struct
    {
        T value;

        bool hasValue;

        public MyNullable(T value)
        {
            this.value = value;
            hasValue = true;
        }
        public override string ToString()
        {
            return HasValue ? value.ToString() : string.Empty ;
        }
        public T Value { get { return value; } }
        public bool HasValue { get { return hasValue; } }
    }
}
