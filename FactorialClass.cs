using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialP
{
    public class FactorialClass
    {
        public int a = 3;
        public int factorial(int a)
        {
            int res = 1;
            for (int i = 1; i <= a; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
