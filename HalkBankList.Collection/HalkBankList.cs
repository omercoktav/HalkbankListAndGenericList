using System;
using System.Collections;

namespace HalkBank.Collections
{
    public class HalkBankList : Iterelenebilir, IBankList
    {
        protected static object[] _dizi;

        public HalkBankList() : base(_dizi)
        {

            _dizi = new object[0];
        }

        public HalkBankList(int maxElemanSayisi) : this()
        {
            MaxElemanSayisi = maxElemanSayisi;
        }

        public int ElemanSayisi => _dizi.Length;
        public static int MaxElemanSayisi { get; set; } = 5;

        public object this[int index] //C# 7.0
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public virtual void Ekle(object eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new System.Exception($"Maksimum eleman sayısına ulaştınız");

            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length + 1];

            yedekDizi.CopyTo(_dizi, 0);

            _dizi[yedekDizi.Length] = eleman;
        }


        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new object[yedekDizi.Length - 1];

            int sayac = 0;

            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                _dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }

        public void Temizle()
        {
            _dizi = new object[0];
        }
        public void TersineCevir()
        {

            int j = _dizi.Length - 1;
            object temp;
            for (int i = 0; i < _dizi.Length; i++)
            {
                if (j <= i)
                {
                    break;
                }
                temp = _dizi[i];
                _dizi[i] = _dizi[j];
                _dizi[j] = temp;

                j--;
            }
        }


        public Object Kopyala(object[] dizi1, int index)
        {
            for (int i = index; i < _dizi.Length; i++)
            {
                dizi1[i] = _dizi[i];
            }
            return dizi1;
        }

        public int IlkIndexBul(object eleman)
        {
            bool kontrol = false;
            int i;
            for (i = 0; i < _dizi.Length; i++)
            {
                if (_dizi[i] == eleman)
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;


        }
        public int IlkIndexBul(object eleman, int baslangicIndeksi)
        {
            if (baslangicIndeksi > _dizi.Length)
            {
                return -1;
            }
            bool kontrol = false;
            int i;
            for (i = baslangicIndeksi; i < _dizi.Length; i++)
            {
                if (_dizi[i] == eleman)
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;

        }
        public int SonIndexBul(object eleman)
        {
            bool kontrol = false;
            int i;
            for (i = _dizi.Length - 1; i > 0; i--)
            {
                if (_dizi[i] == eleman)
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;
        }
        public int SonIndexBul(object eleman, int baslanicIndeksi)
        {
            if (baslanicIndeksi > _dizi.Length)
            {
                return -1;
            }
            bool kontrol = false;
            int i;
            for (i = _dizi.Length - 1; i > baslanicIndeksi; i--)
            {
                if (_dizi[i] == eleman)
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;
        }
        public Iterelenebilir GetEnumerator()
        {
            return new Iterelenebilir(_dizi);
        }
    }
}