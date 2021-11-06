using System;

namespace ifStatements4Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc = 0;
            char islem;

            Console.WriteLine("1. Sayıyı giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /)");
            islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == '*')
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == '/')
            {
                sonuc = sayi1 / sayi2;
            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            else
            {
                Console.WriteLine("Geçersiz İşlem");
            }

            Console.WriteLine($"işlem sonucunuz = {sonuc}");
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
