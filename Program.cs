using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijestupneGodine_IvaSosic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PocGod = 1900, ZavGod = 2100;
            for (int i = PocGod; i <= ZavGod; i++)
            {
                if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0))
                {
                    Console.WriteLine(i);
                }
        }

        Console.ReadKey();
        }
    }
}
