using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HalkBank.Collections
{
    public class Iterelenebilir : IIterelenebilir
    {
        object[] dizi;
        int indeks = -1;
        public Iterelenebilir(object[] _dizi)
        {
            this.dizi = _dizi;
        }
        public object Current => dizi[indeks];

        public bool MoveNext()
        {
            return ++indeks < dizi.Length;
        }

        public void Reset()
        {
            indeks = -1;
        }
    }
}