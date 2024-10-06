using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    internal class LottoMax
    {
        public static int Factorial(int factorial_n, int factorial_len=0)
        {
            int factorial_result = 1;

            if (factorial_len == 0)
            {
                factorial_len = factorial_n;
            }

            while(factorial_len > 0)
            {
                factorial_result *= factorial_n;
                factorial_len--;
                factorial_n--;
            }

            return factorial_result;
        }

        public static int calc_combination(int combination_n, int combination_m)
        {
            int combination_n_calc, combination_m_calc, combination_result;
            if (combination_m != 0)
            {
                combination_n_calc = Factorial(combination_n, combination_m);
                combination_m_calc = Factorial(combination_m);
                combination_result = Math.Round(combination_n_calc / combination_m_calc);

            }
            else
            {
                combination_result = 1;
            }
            return combination_result;
        }
    }
}
