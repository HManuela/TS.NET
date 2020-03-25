using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_lab1
{
    class prim
    {
        static void Main(string[] args)
        {
            Boolean notfound = true;
            string given = Console.ReadLine();
            int number = Convert.ToInt32(given);
            while (number >= 2 && notfound)
            {
                int i;
                for (i = 2; i <= number / 2; i++)
                    if (number % i == 0)
                        break;
                if (i == number / 2)
                {
                    notfound = false;
                    Console.WriteLine(number);
                }
            number =number - 1;

            }
        }
    }
}
