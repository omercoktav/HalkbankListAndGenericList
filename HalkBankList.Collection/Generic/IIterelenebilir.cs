using System;
using System.Collections.Generic;
using System.Text;

namespace HalkBank.Collections.Generics
{
    internal interface IIterelenebilir<T>
    {
        T Current { get; }

        bool MoveNext();
        void Reset();
    }
}