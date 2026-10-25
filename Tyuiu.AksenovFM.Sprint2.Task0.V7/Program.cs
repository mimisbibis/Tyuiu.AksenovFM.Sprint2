using Tyuiu.AksenovFM.Sprint2.Task0.V7.Lib;
namespace Tyuiu.AksenovFM.Sprint2.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Аксенов Ф. М. | РППб-26-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Спринт #2");
            Console.WriteLine("Тема: Базовые навыки работы в C#");
            Console.WriteLine("Задание #0");
            Console.WriteLine("Вариант #7");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                         *");
            Console.WriteLine("************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
