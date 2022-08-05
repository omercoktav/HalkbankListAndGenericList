using System;
using System.Collections.Generic;
using System.Text;

namespace HalkBank.Collections.Generics
{
    internal interface IBankList<T>
    {
        void Ekle(T eleman);

        void Sil(int index);

        void Temizle();
        void TersineCevir();
        int IlkIndexBul(T eleman);
        int IlkIndexBul(T eleman, int baslangicIndeksi);
        int SonIndexBul(T eleman);
        int SonIndexBul(T eleman, int baslangicIndeksi);
        void Kopyala(T[] dizi, int indeks);
        void KosulUygunSil(Func<T, bool> kosul);
        int ElemanSayisi { get; }
    }
}