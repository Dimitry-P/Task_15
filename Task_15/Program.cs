using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    internal class Program
    {
        public static string phrase;
        public static string letter = "а";
        public static int timer = 0;
        
        //•	Задача 15: Напишите программу, которая подсчитывает,
        //сколько раз буква 'a' встречается в строке.
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            phrase = Console.ReadLine();
            for(int i= 0; i<phrase.Length; i++)
            {
                if (phrase[i] == char.Parse(letter)) timer++;
            }
            Console.WriteLine("Буква а встречается в строке: " + timer + " раз");
        }
    }
}
