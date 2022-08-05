using System;
using System.Collections.Generic;
using System.Text;

namespace HalkBank.Collections
{
    internal interface IIterelenebilir
    {
        object Current { get; }

        bool MoveNext();
        void Reset();

    }
}