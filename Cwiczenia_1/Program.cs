using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //początek
            Console.Write("Czesc! Ile liczb chcesz zsumować?: ");
            string snumber = Console.ReadLine();

            int[] numbers = new int[Convert.ToInt32(snumber)];

            //pobieranie liczb od użytkownika
            for (int i = 0; i < numbers.Length; i++)
            {
                string numberofanumber = (i + 1).ToString();
                Console.Write("Podaj" + numberofanumber + "liczbę: ");
                string s = Console.ReadLine();
                numbers[i] = Convert.ToInt32(s);
            }
            //wyświetlanie podanych liczb
            Console.Write("Podane przez Ciebie liczby to: ");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i].ToString() + ", ");
            Console.WriteLine();

            //obliczanie sumy z podanych liczb
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            Console.WriteLine("Suma liczb: " + sum.ToString());
            Console.ReadKey();
        }

    }
}
