using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AksenovFM.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindAmountDaysInMonth(int value)
        {
            return value switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new ArgumentException($"Месяц от 1 до 12. Значенгие {value}")
            };
        }
    }
}