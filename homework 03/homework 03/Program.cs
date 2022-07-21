using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            s1 = Console.ReadLine();

            int i1;
            i1 = int.Parse(s1);
            Console.WriteLine(i1);

            float f1;
            f1 = (float)i1;
            Console.WriteLine(f1);

            s1 = Convert.ToString(f1);
            Console.WriteLine(s1);

            Console.ReadKey();
        }
    }
}
