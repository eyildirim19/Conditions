using System;

namespace ifStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //  mesaj eğer a değeri b'den büyükse gösterilsin...
            int a = 3, b = 1;
            // koşul ifadeleri programın akışı değiştirmek için kullanılır..
            /*  if(<kosul>) // koşul sağlanırsa
             *  {
             *      <kosulluKodlar> // koşullu kodumuz çalışacaktır....
             *  }
            */
            bool durum = a > b;
            //if (durum == true) // a > b
            if (a > b)
            {
                Console.WriteLine("Hello World!");  // koşullu kod...
            }


            Console.ReadKey();
        }
    }
}
