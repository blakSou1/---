using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        Private string name, job,age;
        
        static void Main(string[] args)
        {
            Console.WriteLine("как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("кем вы работаете?");
            job = Console.ReadLine();
            Console.WriteLine("сколько вам лет?");
            age = Console.ReadLine();
            Console.WriteLine("Вас зовут:" + name);
            Console.WriteLine("ваша работа:" + job);
            Console.WriteLine("ваш возраст:" +  age);
            Console.ReadKey();
        }
        
    }
}
