using HalkBank.Collections;
using HalkBank.Collections.Generics;
using System.Collections;

namespace HalkBank.Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();

            HalkBankList.MaxElemanSayisi = 20;

            var liste = new HalkBankList(10);


            liste.Ekle("Salih");
            liste.Ekle(100);
            liste.Ekle(false);
            liste.Ekle("Ahmet");
            liste.Ekle("Mustafa");
            liste.Ekle("Mustafa 2");
            liste.Ekle("Mustafa 3");
            liste.Ekle("Mustafa 4");



            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);

            liste[1] = "Mehmet";

            Console.WriteLine("İlk Eleman: {0}", liste[0]);

            liste.Sil(2);

            //for (int i = 0; i < liste.ElemanSayisi; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}


            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            Console.WriteLine("Tersine Cevrilmis : ");
            liste.TersineCevir();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //liste.Temizle();

            var sayilar = new HalkBankList();
            //sayilar.MaxElemanSayisi = 10;

            Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);

            Console.WriteLine("*****************");
            HalkBankList<string> isimler = new HalkBankList<string>();
            isimler.Ekle("Salih");
            isimler.Ekle("Ahmet");
            isimler.Ekle("Mustafa");
            isimler.Ekle("Mustafa 2");
            isimler.Ekle("Mustafa 3");

            foreach (var item in isimler)
            {
                Console.WriteLine("Generic: " + item);
            }

            HalkBankList<int> sayilar3 = new HalkBankList<int>();

            sayilar3.Ekle(10);
            sayilar3.Ekle(20);
            sayilar3.Ekle(30);
            sayilar3.Ekle(40);
            sayilar3.Ekle(50);
            sayilar3.Ekle(60);
            Console.WriteLine("------RemoveAll Oncesi 20 den büyük Siler-----");
            foreach(var item in sayilar3)
            {
                Console.WriteLine(item);
            }
            sayilar3.KosulUygunSil(t => t > 20);
            Console.WriteLine("RemoveAll  Silinenlerden sonra Dizi : ");
            foreach (var item in sayilar3)
            {
                Console.WriteLine("Tek Tek :  " + item);
            }
           

            Console.WriteLine("--------------------");

            HalkBankList kop2 = new HalkBankList();

            kop2.Ekle("Mustafa");
            kop2.Ekle("Mustafa 2");
            kop2.Ekle("Mustafa 3");
            kop2.Ekle("Mustafa 4");
            object[] array = new object[kop2.ElemanSayisi];
            kop2.Kopyala(array, 0);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------Sondan Index Bulma------");
            HalkBankList sondanBulmaList = new HalkBankList();
            SondanIndexBul(sondanBulmaList);

            Console.WriteLine("------Ilk Index Bulma------");
            HalkBankList ilkIndexBulmaList = new HalkBankList();
            IlkIndexBul(ilkIndexBulmaList);

        }

        private static void SondanIndexBul(HalkBankList liste)
        {
            liste.Ekle("Mehmet");
            liste.Ekle("omer");
            liste.Ekle("riza");
            liste.Ekle("ahmet");

            Console.WriteLine("Sondan Numaralandırmaaa={0}", liste.SonIndexBul("omer"));
        }
        private static void IlkIndexBul(HalkBankList liste)
        {
            liste.Ekle("Mehmet");
            liste.Ekle("omer");
            liste.Ekle("riza");
            liste.Ekle("ahmet");

            Console.WriteLine("Sondan Numaralandırmaaa={0}", liste.IlkIndexBul("omer"));
        }

        private static void ArrayListDemo()
        {
            ArrayList liste = new ArrayList();
            liste.Add("Salih");
            liste.Add(100);
            liste.Add(false);

            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı: {0}", liste.Count);

            liste[1] = "Mehmet";

            Console.WriteLine("İlk Eleman: {0}", liste[0]);

            liste.RemoveAt(2);

            liste.Clear();
        }
    }
}