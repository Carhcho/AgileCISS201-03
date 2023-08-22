using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//9/13/2020
namespace dropbox03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lynn's Pizza, We also sell cookies");
            Console.WriteLine("How many cookies do you want today?");
            int cookies = Convert.ToInt32(Console.ReadLine());
            int dozens = cookies / 12;
            int notdozens = cookies - dozens * 12;
            double cost = dozens + (notdozens * 0.10);
            Console.WriteLine("The cost for your " + cookies + " cookies is going to be " + cost + " dollars");
            Console.Read();
        }
    }
}
