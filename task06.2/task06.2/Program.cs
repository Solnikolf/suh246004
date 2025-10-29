using System;

namespace StringConcatTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово перевозка, чтобы получить новые слова");
            string perevozka = Console.ReadLine();

            string LC1 = perevozka.Substring(0, 1);  //     п                   // Перевозка 
            string LC2 = perevozka.Substring(5, 1);  //     о
            string LC3 = perevozka.Substring(4, 1);  //     в
            string LC4 = perevozka.Substring(4, 3);  //     воз
            string LC5 = perevozka.Substring(6, 1);  //     з 
            string LC6 = perevozka.Substring(1, 1);  //     е
            string LC7 = perevozka.Substring(2, 3);  //     рев
            string LC8 = perevozka.Substring(7, 2);  //     ка

            string resultA = LC1 + LC2 + LC4 + LC8;
            string resultB = LC3 + LC6 + LC7 + LC8;

            Console.WriteLine("Исходное слово: " + perevozka);
            Console.WriteLine("Новое слово A: " + resultA);
            Console.WriteLine("Новое слово B: " + resultB);


        }
    }
}
