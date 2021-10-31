using System;

namespace ifelseifstatemantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2; // değişkenler tanımlıyoruz...

            Console.WriteLine("1. Sayıyı Giriniz");
            sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            sayi2 = int.Parse(Console.ReadLine());

            // birbirine bağlı koşulların kontrolü için kullanılır...
            // 5,3
            if (sayi1 > sayi2)
            {
                Console.WriteLine("1. Sayı Büyük");
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine("2. Sayı Büyük");
            }
            else
            {
                Console.WriteLine("Sayılar eşit");
            }

            /*

                1) kullanıcıdan tam sayı değer istenecek. sayı pozitifse sayı pozitif mesajı, negatifse negatig mesajı 0 ise sayı 0'dır mesajı ekranda gösterilecek... 

                2 ) kullanıcında vize ve final notları istenecek. alınan vize ve finalden ortalama hesaplanacak. Vizenin 0.4'ü finalin 0.6'sı. ve ortalması 100 ile 80 arasında ise AA, 80 ve 70 arasında ise BA diğer değer aralıklarını belirleyerek ekrana harf notunu gösteren mesajı veren prog. yazınız..

            CUMA GÜNÜ ÖDEVLERİ TESLİM EDELİM...
 
             */

            Console.ReadKey();
        }
    }
}
