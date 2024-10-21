using Tyuiu.SchcapovMA.Sprint3.Task1.V15.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task1.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет              *");
            Console.WriteLine("* произведение ряда по формуле, при х=2      5                            *");
            Console.WriteLine("*                                         -------                         *");
            Console.WriteLine("*                                         |     |                         *");
            Console.WriteLine("*                                         |     |   x^2*i+1               *");
            Console.WriteLine("*                                         |     |                         *");
            Console.WriteLine("*                                         |     |                         *");
            Console.WriteLine("*                                          i = 1                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            int x = 2;
            int startValue = 1;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда равно = " + ds.GetMultiplySeries(x,startValue, stopValue));
            Console.ReadKey();
        }
    }
}
