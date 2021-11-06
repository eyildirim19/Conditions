using System;

namespace switchCaseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Switch Case");

            // if-else if => bloklarının alternatifi olarak düşünülebilir...
            // daha sadece if-else if yazmak için kullanılır...

            Console.WriteLine("1 sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi % 2; // sayinin 2'ye bölümden kalanını verir...
            // ifade swithc'te değerler case'de kontrol edilir...
            // break komutu => bulunduğu bloğu sonlandırmak için kullanılan bir komuttur. break ifadesiin altındaki komutlar çalıştırılmaz...

            // Case'ler unique (benzersiz) olmalıdır...
            switch (sonuc) // kontrol edilecek değer....
            {
                case 0:
                    Console.WriteLine("çift sayı");
                    break;
                //case 0:
                //    Console.WriteLine("denasda");
                //    break;
                case 1:
                    Console.WriteLine("tek sayı");
                    break;
            }
            Console.ReadKey();
        }
    }
}
