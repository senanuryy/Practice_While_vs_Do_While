using System;

namespace PracticeWhilevsDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While");
            Console.WriteLine("-------------------------------------");
            Console.Write("Bir limit değeri giriniz: ");
           
            int limit = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i <= limit)
            {
                Console.WriteLine($"{i}- Ben bir Patika'lıyım");
                i++;
            }

            Console.WriteLine("\nDo-While");
            Console.WriteLine("-------------------------------------");
            Console.Write("Bir limit değeri giriniz: ");

            Console.Write("Bir limit değeri giriniz: ");

            int limit2 = Convert.ToInt32(Console.ReadLine());

            int j = 0;

            do
            {                
                Console.WriteLine($"{j}- Ben bir Patika'lıyım");
                j++;

            } while (j <= limit2);

            // While ve Do-While Döngüleri Arasındaki Fark:
            // 1. While döngüsü, koşulun başta kontrol edilmesi nedeniyle, koşul sağlanmıyorsa döngü hiç çalışmaz.
            //    Örneğin, limit -5 girildiğinde while döngüsü bir kez bile çalışmaz.

            // 2. Do-While döngüsü ise önce döngü içindeki işlemleri yapar, ardından koşulu kontrol eder.
            //    Bu nedenle koşul sağlanmasa bile, döngü en az bir kez çalışır.
            //    Örneğin, limit -5 girildiğinde do-while döngüsü bir kez "Ben bir Patika'lıyım" yazdırır.

            // Özet: While döngüsü, koşula bağlı olarak çalışmayabilir. 
            // Do-While döngüsü ise koşula bakmaksızın en az bir kez çalışır.
        }
    }
}