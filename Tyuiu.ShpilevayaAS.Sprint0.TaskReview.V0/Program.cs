using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShpilevayaAS.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            int z = 2;
            int res = DataService.Calc(x, y, z);
            Console.WriteLine($"({x} + {y} + {z})* 5 = " + res);
            Console.ReadKey();
        }
    }
}
