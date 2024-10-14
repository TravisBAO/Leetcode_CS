using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{

    internal class LottoMax
    {
        public const int Total_Balls = 50;
        public const int Maximum_Match_Ball = 7;
        public const int Unmatched_Ball = Total_Balls - Maximum_Match_Ball;
        public const int Tickets = 3;
        public float All_Combinations = Calc_combination(Total_Balls, Maximum_Match_Ball);


        public static long Factorial(int factorial_n, int factorial_len=0)
        {
            long factorial_result = 1;

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

        public static float Calc_combination(int combination_n, int combination_m)
        {
            long combination_n_calc, combination_m_calc;
            float combination_result;
            if (combination_m != 0)
            {
                combination_n_calc = Factorial(combination_n, combination_m);
                combination_m_calc = Factorial(combination_m);
                combination_result = combination_n_calc / combination_m_calc;
            }
            else
            {
                combination_result = 1;
            }
            return combination_result;
        }

        public void Odds_calc(int matched_ball_amount, bool with_bonus)
        {
            float partial_match_odds = 0;
            float partial_match_odds_percent = 0;

            if (with_bonus == false)
            {
                //选中的球中匹配球的组合
                float choosed_matched_odds = Calc_combination(Maximum_Match_Ball, matched_ball_amount);
                //选中的球中不匹配球的组合
                int choosed_unmatched_ball = Maximum_Match_Ball - matched_ball_amount;
                float choose_unwatched_odds = Calc_combination(Unmatched_Ball, choosed_unmatched_ball);
                partial_match_odds = All_Combinations / (choosed_matched_odds * choose_unwatched_odds * Tickets);
                partial_match_odds_percent = Percentage(1, partial_match_odds);
                
            }
            else
            {
                //pass
            }
            Console.WriteLine();
            Console.WriteLine("Match {0}'s odd is 1/{1}", matched_ball_amount, partial_match_odds);
            Console.WriteLine("Match {0}'s odd in percent is {1}", matched_ball_amount, partial_match_odds_percent.ToString("P6"));
        }

        public static float Percentage(float part, float whole)
        {
            float percentage = part / whole;
            return percentage;
        }
    }
}
