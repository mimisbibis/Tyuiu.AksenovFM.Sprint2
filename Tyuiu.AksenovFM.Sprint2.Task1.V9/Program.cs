using Tyuiu.AksenovFM.Sprint2.Task1.V9.Lib;
namespace Tyuiu.AksenovFM.Sprint2.Task1.V9

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Аксенов Ф. М. | РППб-26-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Спринт #2");
            Console.WriteLine("Тема: Базовые навыки работы в C#");
            Console.WriteLine("Задание #1");
            Console.WriteLine("Вариант #9");
            Console.WriteLine("Выполнил: Аксенов Ф. М. | РППб-26-1");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("*******************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                    *");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("*******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                          *");
            Console.WriteLine("*******************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
