using System;

namespace Daire_Çizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını girin: ");
            double yaricap = double.Parse(Console.ReadLine());
             
            
            for (int x = -(int)yaricap; x <= (int)yaricap; x++)
            {
                for (int y = -(int)yaricap; y <= (int)yaricap; y++)
                {
                    if (x * x + y * y <= yaricap * yaricap)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
           Console.ReadKey();
        }
    }
}
