using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AksenovFM.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            if (prevDay == 0)
            {
                prevMonth = prevMonth - 1;

                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear = prevYear - 1;
                }

                switch (prevMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        prevDay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        prevDay = 30;
                        break;
                    case 2:
                        prevDay = 28;
                        break;
                }
            }

            string dayStr = prevDay.ToString("D2");
            string monthStr = prevMonth.ToString("D2");

            return $"{dayStr}.{monthStr}.{prevYear}";
        }
    }
}