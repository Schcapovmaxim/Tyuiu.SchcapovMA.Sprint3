using Tyuiu.SchcapovMA.Sprint3.Task0.V5.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task0.V5
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
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* сумму ряда по формуле: 10                                               *");
            Console.WriteLine("*                       ----                                              *");
            Console.WriteLine("*                       \\                1       1                       *");
            Console.WriteLine("*                        |             ----- * -----                      *");
            Console.WriteLine("*                       /              sin(k)  sin(k)                     *");
            Console.WriteLine("*                       ----                                              *");
            Console.WriteLine("*                       k=1                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда равна = " + ds.GetSumSeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
