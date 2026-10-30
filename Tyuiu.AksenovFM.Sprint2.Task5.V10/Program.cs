using Tyuiu.AksenovFM.Sprint2.Task5.V10.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfPreviousDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Предыдущая дата: " + res);

            Console.ReadKey();
        }
    }
}