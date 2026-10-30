using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AksenovFM.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}