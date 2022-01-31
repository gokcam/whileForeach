using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam);


            // 'a' dan 'z' ye kadar tüm harfleri yazdır
            char character = 'a';
            while(character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            //Foreach
            Console.WriteLine("*******Foreach********");
            string[] cars = { "bmw", "toyota", "nissan" };
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}