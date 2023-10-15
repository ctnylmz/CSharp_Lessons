using System;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "İhtiyaç Kredesi";

            int krediTutari = 10000;

            double faizOranı = 0.45;

            double toplamFaiz = krediTutari * faizOranı;

            bool giris = false;

            if (giris == true)
            {
                Console.WriteLine(kategoriEtiketi + " Kredi Onaylandı!");
                Console.WriteLine(krediTutari + "TL Geri Ödeme ile " + (krediTutari + toplamFaiz) + "TL");
            }
            else if (giris == false)
            {
                Console.WriteLine("Lütfen Giriş Yapın");
            }
            else
            {
                Console.WriteLine("Hata Lütfen İletişime Geçin");
            }
        }
    }

}
