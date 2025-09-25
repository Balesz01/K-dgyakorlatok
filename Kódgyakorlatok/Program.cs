using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kódgyakorlatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //új gyakorlatok 
            //Készíts egy 20 elemű egy dimenziós egész számokból álló tömböt
            //Töltsd fel 20 és 30 közé eső véletlen számokkal
            //határozd meg a tömb legkisebb és legnagyobb elemét (a tanult programozási tételekből)
            Random rnd = new Random();
            int[] numbers = new int [20]; 

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(20, 30);
            }

            int maxszam = numbers[0];
            int kisszam = numbers[0];

            foreach (var item in numbers)
            {
                if (item > maxszam)
                {
                    maxszam = item;
                }
            }
            foreach (var item in numbers)
            {
                if (item < kisszam)
                {
                    kisszam = item;
                }
            }
            Console.WriteLine($"A legnagyobb szám a tömbben: {maxszam}");
            Console.WriteLine($"A legkisebb elem a tömbben: {kisszam}");
            Console.ReadLine();
        }
    }
}
