using System;

namespace ifStatemanets2
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı adı admin ve şifre 123 ise ekrana hoş geldin admin mesajını veren, bilgiler doğru değilse hatalı bilgi girdiniz mesajı veren uygulama
            string kullaniciAdi, sifre;

            Console.WriteLine("Kullanıcı Adı Giriniz");
            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz");
            sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "123") // koşul sağlanırsa...
            {
                Console.WriteLine("Hoş geldin admin");
            }
            else // sağlanmazsa
            {
                Console.WriteLine("hatalı kullanıcı adı veya şifre girdiniz");
            }


            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
