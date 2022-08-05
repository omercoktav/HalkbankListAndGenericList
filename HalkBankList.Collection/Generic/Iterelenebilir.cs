using System;
using System.Collections.Generic;
using System.Text;

namespace HalkBank.Collections.Generics
{
    public class Iterelenebilir<T> : IIterelenebilir<T>
    {
        T[] _dizi;
        int indeks = -1;

        public Iterelenebilir(T[] _dizi)
        {
            this._dizi = _dizi;
        }
        public T Current => _dizi[indeks];

        public bool MoveNext()
        {
            return ++indeks < _dizi.Length;
        }

        public void Reset()
        {
            indeks = -1;
        }
    }
}