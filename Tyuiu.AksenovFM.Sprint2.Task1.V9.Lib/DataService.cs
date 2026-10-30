using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.AksenovFM.Sprint2.Task1.V9.Lib;
//Написать программу из операций сравнений
//(==, !=, <, >, <=, >=, последовательность можно чередовать,
//но использовать один раз в выражении) и логических операций
//(|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(False, False, True, False, True, False), при a = 15, b = 335, c = 174, d = 478
namespace Tyuiu.AksenovFM.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c + 900 < d);
            res[1] = (a > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a > b) && (c < d);
            res[4] = !(res[0]);
            res[5] = (a > b) ^ (c + 900 < d);

            return res;    
        } 
    }
}
