using Tyuiu.AksenovFM.Sprint2.Task6.V1.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int value = Convert.ToInt32(Console.ReadLine());

            int res = ds.FindAmountDaysInMonth(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество дней: " + res);

            Console.ReadKey();
        }
    }
}