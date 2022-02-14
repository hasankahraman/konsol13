using System;

namespace konsol13
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler

            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);
            
            if(sonuc){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);

            } else {
                Console.WriteLine("Başarısız");
            }

            Metotlar metot = new Metotlar();
            metot.Topla(2,3, out int toplamSonuc);

            Console.WriteLine(toplamSonuc);

            //Metot - aşırı yükleme -- overloading

            int ifade = 999;
            metot.EkranaYazdir(Convert.ToString(ifade));

            metot.EkranaYazdir(ifade);

            //Metot imzası
            //metot adı + parametre sayısı + parametre

            metot.EkranaYazdir("Hasan",     " KAHRAMAN");


        }
    }

    class Metotlar {

        public void Topla ( int a, int b, out int Toplam){

            Toplam = a+b;
        }

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri){
            Console.WriteLine(Convert.ToString(veri));
        }

        public void EkranaYazdir(string veri1, string veri2){
            Console.WriteLine(veri1 + veri2);
        }


    }
}
