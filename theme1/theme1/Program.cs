using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theme1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name :");//Enter your username
            string name = Console.ReadLine();//this will save in name string
            Console.WriteLine("Hello "+name);
            Console.WriteLine("Hi "+name+ " from git");
        }
    }
}
