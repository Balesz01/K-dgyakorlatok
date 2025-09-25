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

            //2.Készíts egy szövegeket tartalmazó hét elemű tömböt. Állapítsd meg hány olyan szöveg van a tömbben, amiben van u betű!

            string[] szoveg = new string[7] {"valami","kuka","tegnap","dunka","marlon","lacy","pdd"};
            int darab = 0;
            foreach (var item in szoveg)
            {
                if (item.Contains("u") || item.Contains("U"))
                {
                    darab++;
                }
            }
            Console.WriteLine($"A szövegek tömbben: {darab} szóban van 'u'");
            Console.ReadLine();

            //2 dimenziós tömb
            //ha az elem egyetlen sorszámmal azonosítható a tömbbrn akkor az egydimenziós tömb (tulajdonkép elemek egyszerű sora)
            //ha azonosításhoz két indexet használunk akkor kétdimenziós tömb (olyan mint a táblázat)
            int[,] tablazat = new int[2,3];
            //adjuk meg egyesével
            tablazat[0,0] = 1;
            tablazat[0,1] = 2;
            tablazat[0,2] = 3;
            tablazat[1,0] = 5;
            tablazat[1,1] = 6;
            tablazat[1,2] = 7;

            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                for (int j = 0; j < tablazat.GetLength(1); j++)
                {
                    Console.Write($"{tablazat[i,j]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
