using System;
using System.Collections;

namespace HalkBank.Collections.Generics
{
    public class HalkBankList<T> : Iterelenebilir<T>, IBankList<T>
    {
        protected static T[] _dizi;

        public HalkBankList() : base(_dizi)
        {
            _dizi = new T[0];
        }

        public HalkBankList(int maxElemanSayisi) : base(_dizi)
        {
            MaxElemanSayisi = maxElemanSayisi;
        }

        public int ElemanSayisi => _dizi.Length;
        public static int MaxElemanSayisi { get; set; } = 8;

        public T this[int index] //C# 7.0
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public virtual void Ekle(T eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new System.Exception($"Maksimum eleman sayısına ulaştınız");

            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length + 1];

            yedekDizi.CopyTo(_dizi, 0);

            _dizi[yedekDizi.Length] = eleman;
        }

        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length - 1];

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
            _dizi = new T[0];
        }



        public void TersineCevir()
        {
            int j = _dizi.Length - 1;
            T temp;
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

        public int IlkIndexBul(T eleman)
        {
            bool kontrol = false;
            int i;
            for (i = 0; i < _dizi.Length; i++)
            {
                if (_dizi[i].Equals(eleman))
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;
        }

        public int IlkIndexBul(T eleman, int baslangicIndeksi)
        {
            if (baslangicIndeksi > _dizi.Length)
            {
                return -1;
            }
            bool kontrol = false;
            int i;
            for (i = baslangicIndeksi; i < _dizi.Length; i++)
            {
                if (_dizi[i].Equals(eleman))
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;
        }

        public int SonIndexBul(T eleman)
        {
            bool kontrol = false;
            int i;
            for (i = _dizi.Length - 1; i > 0; i--)
            {
                if (_dizi[i].Equals(eleman))
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;
        }

        public int SonIndexBul(T eleman, int baslangicIndeksi)
        {
            if (baslangicIndeksi > _dizi.Length)
            {
                return -1;
            }
            bool kontrol = false;
            int i;
            for (i = _dizi.Length - 1; i > baslangicIndeksi; i--)
            {
                if (_dizi[i].Equals(eleman))
                {
                    kontrol = true;
                    break;
                }

            }
            if (kontrol == true) return i;
            else return -1;
        }
        public Iterelenebilir<T> GetEnumerator()
        {
            return new Iterelenebilir<T>(_dizi);
        }

        public void KosulUygunSil(Func<T, bool> kosul)
        {
            int sayac = 0;
            var yedekDizi = new T[_dizi.Length];

            for (int i = 0; i < _dizi.Length; i++)
            {
                bool kosulSaglandimi = kosul.Invoke(_dizi[i]);
                if (!kosulSaglandimi)
                {
                    yedekDizi[sayac] = _dizi[i];
                    sayac++;
                }

            }
            _dizi = new T[sayac];
            for (int i = 0; i < sayac; i++)
            {
                _dizi[i] = yedekDizi[i];
            }

        }

        public void Kopyala(T[] dizi, int indeks)
        {
            for (int i = indeks; i <= _dizi.Length; i++)
            {
                dizi[i] = _dizi[i];
            }

        }
    }
}