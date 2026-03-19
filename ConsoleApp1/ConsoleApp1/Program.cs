using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        Random rand = new Random();
        static void Main(string[] args)
        {
            var rand = new Random();

            //варіант 1 завдання 5

            /*Console.WriteLine("Введіть число а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число б");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                b = a + 1;
            }
            else if (a == b)
            {
                b = b+1;
            }
            Console.WriteLine($"А = {a}, Б = {b}");   */

            //варіант 2 завдання 5

            /*Console.WriteLine("Введіть число а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число б");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                a = b - 1;
            }
            Console.WriteLine($"А = {a}, Б = {b}");    */

            //варіант 1 завдання 6
            Console.WriteLine("Введіть число а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число б");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            if (a == b)
            {
                c = a + b;
            }
            else 
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(c);


        }
    }
}
