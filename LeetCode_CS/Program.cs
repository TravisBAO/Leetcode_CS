using LeetCode_CS;
using System;

class Program
{
    public static void Main(string[] args)
    {
        //LottoMax MyLottoMax = new();
        //MyLottoMax.Odds_calc(7, false);
        //MyLottoMax.Odds_calc(6, false);
        //MyLottoMax.Odds_calc(5, false);
        //MyLottoMax.Odds_calc(4, false);
        //MyLottoMax.Odds_calc(3, false);
        //MyLottoMax.Odds_calc(2, false);
        //MyLottoMax.Odds_calc(1, false);
        //MyLottoMax.Odds_calc(0, false);

        _55_JumpGame _55_JumpGame = new _55_JumpGame();
        //int[] SampleArray = { 2, 3, 1, 1, 4 };
        int[] SampleArray = { 2, 5, 0, 0 };
        bool _55_JumpGameResult = _55_JumpGame.CheckToJumpToEnd(SampleArray);
        Console.WriteLine(_55_JumpGameResult.ToString());
    }
}