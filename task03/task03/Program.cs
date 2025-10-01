using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите четырехзначное число");
            var num = int.Parse(Console.ReadLine());
            var d1 = num / 1000;        
            var d2 = (num / 100) % 10;  
            var d3 = (num / 10) % 10;   
            var d4 = num % 10;

            var result = d2 * 1000 + d1 * 100 + d4 * 10 + d3;

            Console.WriteLine("Результат: " + result);
        }

    }
}