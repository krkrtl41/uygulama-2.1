using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int a = 1; a <= 10; a++)
            {
                if (a % 2 != 0)
                {
                    toplam += a;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
