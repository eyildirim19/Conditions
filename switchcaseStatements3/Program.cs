using System;

namespace switchcaseStatements3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir karakter giriniz");
            char karakter = Convert.ToChar(Console.ReadLine());


            // ascii kod karşılığı
            char a1 = 'a';
            char a2 = 'A';
            // char.ToUpper metodu karakteri büyük yapar...
            switch (char.ToUpper(karakter))
            {
                case 'A':
                case 'I':
                case 'İ':
                case 'O':
                case 'E':
                case 'Ö':
                case 'U':
                case 'Ü':
                    Console.WriteLine("girilen karakter sesli");
                    break;
                default:
                    Console.WriteLine("girilen karakter sessiz");
                    break;
            }

            // aynı mesajları if ile nasıl yapardık...????
            karakter = char.ToUpper(karakter);
            //if (char.ToUpper(karakter) == 'A' || char.ToUpper(karakter) == 'I' || char.ToUpper(karakter) == 'İ')
            if (karakter == 'A' || karakter == 'I' || karakter == 'İ' || karakter == 'O')
            {
                Console.WriteLine("girilen karakter sesli");
            }
            else
            {
                Console.WriteLine("girilen karakter sessiz");
            }


            Console.ReadKey();
        }
    }
}
