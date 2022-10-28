using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string charArray = Console.ReadLine();
            int i = 0; while (i < charArray.Length) Console.WriteLine(charArray[i++]);
            int k = charArray.Length - 1; while (k >= 0) Console.Write(charArray[k--]);
            Console.WriteLine();
        }
    }
}