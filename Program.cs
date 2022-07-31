using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama

            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi", "köpek", "kuş"};

            // Dizilere değer atama ve erişim

            renkler[0] = "siyah";

            Console.WriteLine(hayvanlar[2]);
            Console.WriteLine(renkler[1]);

            // Döngülerde dizilerin kullanımı

            // Klavyeden girilen n tane sayının aritmetik ortalamasını yazan progaram

            Console.Write("Aritmetik ortalamalarını hesaplamak istediğiniz sayıların eleman sayısını giriniz:");

            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lütfen {0}. sayıyı giriniz:", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            float toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.Write("Girdiğiniz sayıların aritmetik ortalaması: " + toplam/diziUzunlugu);
        }   
    }
}