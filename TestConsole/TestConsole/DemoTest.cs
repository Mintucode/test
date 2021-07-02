using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    
   
    class DemoTest
    {
        public static void Main(string[] agr)
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
            string ls = fruits.Aggregate((a, b) => a.Length > b.Length ? a : b);
            Console.WriteLine( ls);

            List<int> l = new List<int>();
            foreach(var i in l.DefaultIfEmpty())
            {
                Console.WriteLine(i);
            }

            string st = null;
            bool bk = string.IsNullOrEmpty(st); //true
            bool bk1 = string.IsNullOrWhiteSpace(st); //true

            Console.WriteLine(bk);
            Console.WriteLine(  bk1);
            Console.ReadLine();

        }
    }
}
