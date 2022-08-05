using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank.Collections
{
    public interface IBankList
    {
        void Ekle(object eleman);

        void Sil(int index);

        void Temizle();
        void TersineCevir();
        int IlkIndexBul(object eleman);
        int IlkIndexBul(object eleman, int baslangicIndeksi);
        int SonIndexBul(object eleman);
        int SonIndexBul(object eleman, int baslangicIndeksi);
        int ElemanSayisi { get; }


        object this[int index]
        {
            get;
            set;
        }
    }
}
