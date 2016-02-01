using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamor
{
    class Program
    {
        static void Main(string[] args)
        {
            string m1 = "Te ";
            string m2 = "Amo ";
            string m3 = "Mucho ";
            string love = "♥ ";
            string boy1 = "Mi ";
            string boy2 = "Niño ";
            string boy3 = "hermoso";
            var message = m1 + m2 + m3;
            var message2 = love + love + love;
            var message3 = boy1 + boy2 + boy3;
            Console.Write(message);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message3);
            Console.ReadLine();
           
           
        }
    }
}
