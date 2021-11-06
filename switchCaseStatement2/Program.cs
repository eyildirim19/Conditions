using System;

namespace switchCaseStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 5 arasında bir değer giriniz");
            int deger = Convert.ToInt32(Console.ReadLine());

            switch (deger)
            {
                case 1:
                    Console.WriteLine("bir");
                    break;
                case 2:
                    Console.WriteLine("iki");
                    break;
                case 3:
                    Console.WriteLine("üç");
                    break;
                case 4:
                    Console.WriteLine("dört");
                    break;
                case 5:
                    Console.WriteLine("beş");
                    break;
                default: // caselerin çalışmama durumunda devreye girer... caselerden biri sağlanmıyorsa default ifadesi çalışır...
                    Console.WriteLine("geçersiz bir rakam..");
                    break;
            }

            Console.ReadKey();
        }
    }
}