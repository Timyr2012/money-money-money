using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

            //Середній рівень завдання 19
            int seconds1 = 7893;
            int minutes = seconds1 / 60;
            Console.WriteLine(minutes);
            //Середній рівень завдання 20
            int seconds2 = 8973;
            int hours = seconds2 / 360;
            Console.WriteLine(hours);
            //Середній рівень завдання 21-22???
            Console.WriteLine(seconds1 + seconds2);
            //Середній рівень завдання 23 варіант 1
            Console.WriteLine((seconds1 + seconds2)/60);
            //Середній рівень завдання 23 варіант 2
            Console.WriteLine(minutes);
            //Середній рівень завдання 23 варіант 3
            Console.WriteLine(hours/60);


        }
    }
}
