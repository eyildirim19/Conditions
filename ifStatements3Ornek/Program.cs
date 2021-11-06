using System;

namespace ifStatements3Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayıyı Giriniz....");
            int sayi1 = Convert.ToInt32(Console.ReadLine()); // stringi int'e dönüştürdük...

            Console.WriteLine("2. Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine()); // string int'e dönüştürdük..

            int sonuc;

            sonuc = sayi1 + sayi2;
            //Console.WriteLine("Girilen Sayıların Toplamı " + sonuc);
            //Console.WriteLine(sayi1 + " Sayısı ile " + sayi2 + " Sayısının toplamı = " + sonuc);
            Console.WriteLine($"{sayi1} Sayısı ile {sayi2} sayısının toplamı = {sonuc}");
            //$ => stringi formatlamak için kullanılır. string içerisine { } ile dışarıdan parametre vermiş oluruz...

            sonuc = sayi1 * sayi2;
            // Console.WriteLine("Girilen Sayıların Çarpımı " + sonuc); // Girilen Sayıların Çarpımı 2
            // formatlı yazalım...
            Console.WriteLine($"{sayi1} sayı ile {sayi2} sayısının çarpımı = {sonuc}");

            sonuc = sayi1 / sayi2;
            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının bölümü = {sonuc}");

            Console.ReadKey(); // beklemeye aldık...
        }
    }
}
