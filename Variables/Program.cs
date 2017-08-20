using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables lesson 
            //int x = 7;
            //int y = x + 3;
            //Console.WriteLine(y);

            //string firstname = "Kessy";
            //Console.WriteLine(firstname);

            int x = 7;
            //string y = "kc";
            string y = "5";
            string firstTry = x.ToString() + y;

            //int secondTry = x + y;
            int secondTry = x + int.Parse(y);

            //Console.WriteLine(firstTry);
            Console.Write(secondTry);
            Console.ReadLine();
        }
    }
}
