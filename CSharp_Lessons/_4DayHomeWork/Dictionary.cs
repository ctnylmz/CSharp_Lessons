//using System;
//using System.Collections.Generic;

//namespace _4DayHomeWork
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Dictionary 
//            Dictionary<string, int> ogrenciNotlari = new Dictionary<string, int>();

//            ogrenciNotlari["Ali"] = 90;
//            ogrenciNotlari["Veli"] = 85;
//            ogrenciNotlari["Ayşe"] = 88;

//            Console.WriteLine("Ali'nin notu: " + ogrenciNotlari["Ali"]);
//            Console.WriteLine("Veli'nin notu: " + ogrenciNotlari["Veli"]);
//            Console.WriteLine("Ayşe'nin notu: " + ogrenciNotlari["Ayşe"]);

//            // Eğer anahtar mevcut değilse hata alabiliriz, bu nedenle kontrol etmek önemlidir
//            if (ogrenciNotlari.ContainsKey("Mehmet"))
//                Console.WriteLine("Mehmet'in notu: " + ogrenciNotlari["Mehmet"]);
//            else
//                Console.WriteLine("Mehmet adında bir öğrenci bulunamadı.");


//            foreach (var ogrenci in ogrenciNotlari)
//            {
//                Console.WriteLine("Öğrenci: " + ogrenci.Key + ", Notu: " + ogrenci.Value);
//            }
//        }
//    }
//}
